using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    public partial class frmProposerCredit : Form
    {
        // pour se souvenir de l'ordre dans lequel les checkbox ont été cochées
        private List<int> ordreListeCheckbox = new List<int>();
        private bool ordreListeCheckboxVerif;
        private DemandePret demandePret = new DemandePret();

        public frmProposerCredit()
        {
            InitializeComponent();
            ordreListeCheckbox.Add(2);
            ordreListeCheckbox.Add(3);
            ordreListeCheckboxVerif = true;
        }

        private void frmProposerCredit_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            try
            {
                Globales.suiteFenetres.afficherFenetrePrecedente(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si le client sélectionné est le client temporaire
                if (Globales.ClientTemporaire != null && Globales.clientSelectionne == Globales.ClientTemporaire)
                {
                    int idx = Globales.suiteFenetres.getIndexFenetreActuelle();
                    // Remove any frmCreerClient present after this window (to avoid duplicates)
                    if (idx + 1 < Globales.suiteFenetres.listeFenetres.Count &&
                        Globales.suiteFenetres.listeFenetres[idx + 1] is frmCreerClient)
                    {
                        Globales.suiteFenetres.listeFenetres.RemoveAt(idx + 1);
                    }
                    frmCreerClient fenCreerClient = new frmCreerClient() { TopLevel = false, TopMost = true };
                    Globales.suiteFenetres.listeFenetres.Insert(idx + 1, fenCreerClient);
                    Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
                    return;
                }

                // Si ce n'est pas un client temporaire, continuer normalement
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProposerCredit_Load(object sender, EventArgs e)
        {
            lblPrixTotalVehicule.Text = Globales.vehiculeSelectionneVente.Prix.ToString() + " €";
            lblPrixTotal.Text = Globales.vehiculeSelectionneVente.Prix.ToString() + " €";
            Globales.prixTotalAFinancer = Globales.vehiculeSelectionneVente.Prix;
        }

        private void cb1_NbMensualités_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1_NbMensualités.Checked)
            {
                ajouterUneCheckboxDansLaListe(1);
                numNbMensualites.Enabled = true;
            }
            else
            {
                retirerUneCheckboxDansLaListe(1);
                numNbMensualites.Enabled = false;
            }
        }

        private void ajouterUneCheckboxDansLaListe(int num)
        {
            if (ordreListeCheckboxVerif == false)
                return;

            ordreListeCheckboxVerif = false;
            ordreListeCheckbox.Add(num);

            switch(ordreListeCheckbox[0])
            {
                case 1:
                    cb1_NbMensualités.Checked = false;
                    break;
                case 2:
                    cb2_MontantMensualites.Checked = false;
                    break;
                case 3:
                    cb3_PremierApport.Checked = false;
                    break;
            }

            ordreListeCheckbox.RemoveAt(0);
            ordreListeCheckboxVerif = true;
        }

        private void retirerUneCheckboxDansLaListe(int num)
        {
            if (ordreListeCheckboxVerif == false)
                return;

            ordreListeCheckboxVerif = false;
            switch (num)
            {
                case 1:
                    if (!ordreListeCheckbox.Contains(2))
                    {
                        ordreListeCheckbox.Add(2);
                        cb2_MontantMensualites.Checked = true;
                    }
                    else if (!ordreListeCheckbox.Contains(3))
                    {
                        ordreListeCheckbox.Add(3);
                        cb3_PremierApport.Checked = true;
                    }
                    break;
                case 2:
                    if (!ordreListeCheckbox.Contains(1))
                    {
                        ordreListeCheckbox.Add(1);
                        cb1_NbMensualités.Checked = true;
                    }
                    else if (!ordreListeCheckbox.Contains(3))
                    {
                        ordreListeCheckbox.Add(3);
                        cb3_PremierApport.Checked = true;
                    }
                    break;
                case 3:
                    if (!ordreListeCheckbox.Contains(1))
                    {
                        ordreListeCheckbox.Add(1);
                        cb1_NbMensualités.Checked = true;
                    }
                    else if (!ordreListeCheckbox.Contains(2))
                    {
                        ordreListeCheckbox.Add(2);
                        cb2_MontantMensualites.Checked = true;
                    }
                    break;
            }
            ordreListeCheckbox.Remove(num);
            ordreListeCheckboxVerif = true;
        }

        private void cb2_MontantMensualites_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2_MontantMensualites.Checked)
            {
                ajouterUneCheckboxDansLaListe(2);
                numMontantMensualites.Enabled = true;
            }
            else
            {
                retirerUneCheckboxDansLaListe(2);
                numMontantMensualites.Enabled = false;
            }
        }

        private void cb3_PremierApport_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3_PremierApport.Checked)
            {
                ajouterUneCheckboxDansLaListe(3);
                numPremierApport.Enabled = true;
            }
            else
            {
                retirerUneCheckboxDansLaListe(3);
                numPremierApport.Enabled = false;
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            demandePret.Taux = (double)numTaux.Value;

            if(!cb1_NbMensualités.Checked)
            {
                // on calcule le nb de mensualités
                demandePret.PremierApport = numPremierApport.Value;
                demandePret.PrixMensualite = numMontantMensualites.Value;
                demandePret.MontantTotal = Globales.prixTotalAFinancer - demandePret.PremierApport;
                decimal interetParAn = demandePret.MontantTotal * (decimal)demandePret.Taux / 100;
                decimal interetParMois = interetParAn / 12;
                decimal remboursementParMois = demandePret.PrixMensualite - interetParMois;
                demandePret.NombreMensualites = (int)Math.Ceiling(demandePret.MontantTotal / remboursementParMois);
                numNbMensualites.Value = (decimal)demandePret.NombreMensualites;
            }
            else if(!cb2_MontantMensualites.Checked)
            {
                // on calcule le montant des mensualités
                demandePret.PremierApport = numPremierApport.Value;
                demandePret.MontantTotal = Globales.prixTotalAFinancer - demandePret.PremierApport;
                demandePret.NombreMensualites = (int)numNbMensualites.Value;
                decimal nombreDAnnees = (decimal)demandePret.NombreMensualites / 12;
                decimal interetParAn = demandePret.MontantTotal * (decimal)demandePret.Taux / 100;
                decimal interetParMois = interetParAn / 12;
                decimal remboursementParMois = demandePret.MontantTotal / demandePret.NombreMensualites;
                demandePret.PrixMensualite = remboursementParMois + interetParMois;
                numMontantMensualites.Value = demandePret.PrixMensualite;
            }
            else
            {
                // on calcule le premier apport
                demandePret.PrixMensualite = numMontantMensualites.Value;
                demandePret.NombreMensualites = (int)numNbMensualites.Value;
                decimal nombreDAnnees = (decimal)demandePret.NombreMensualites / 12;
                decimal totalHorsPremierApport = demandePret.NombreMensualites * demandePret.PrixMensualite;
                demandePret.MontantTotal = totalHorsPremierApport * (1 - nombreDAnnees * (decimal)demandePret.Taux / 100);
                demandePret.PremierApport = Globales.prixTotalAFinancer - demandePret.MontantTotal;
                numPremierApport.Value = demandePret.PremierApport;
            }
        }
    }
}
