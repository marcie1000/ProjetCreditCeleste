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

                // --- AJOUT POUR LE RECAPITULATIF ---
                // Récupère les infos à afficher dans le récapitulatif
                var vehicule = Globales.vehiculeSelectionneVente;
                var client = Globales.clientSelectionne;
                Vendeur vendeur = null; // L'utilisateur n'est pas un vendeur, donc on laisse null ou récupérez-le autrement si besoin
                var montant = Globales.prixTotalAFinancer;
                var prix = vehicule != null ? vehicule.Prix : 0;
                bool vente = true; // ou false si location

                int idxFenetre = Globales.suiteFenetres.getIndexFenetreActuelle();
                // Supprime une éventuelle ancienne fenêtre de récapitulatif à la même position
                if (idxFenetre + 1 < Globales.suiteFenetres.listeFenetres.Count &&
                    Globales.suiteFenetres.listeFenetres[idxFenetre + 1] is frmRecapitulatif)
                {
                    Globales.suiteFenetres.listeFenetres.RemoveAt(idxFenetre + 1);
                }
                frmRecapitulatif fenRecap = new frmRecapitulatif(vehicule, client, vendeur, montant, prix, vente) { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.listeFenetres.Insert(idxFenetre + 1, fenRecap);
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
                // --- FIN AJOUT ---

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

            switch (ordreListeCheckbox[0])
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

            if (!cb1_NbMensualités.Checked)
            {
                // on calcule le nb de mensualités
                demandePret.PremierApport = numPremierApport.Value;
                demandePret.PrixMensualite = numMontantMensualites.Value;
                demandePret.MontantTotal = Globales.prixTotalAFinancer - demandePret.PremierApport;
                decimal interetParAn = demandePret.MontantTotal * (decimal)demandePret.Taux / 100;
                decimal interetParMois = interetParAn / 12;
                decimal remboursementParMois = demandePret.PrixMensualite - interetParMois;
                demandePret.NombreMensualites = (int)Math.Ceiling(demandePret.MontantTotal / remboursementParMois);

                // Correction : clamp la valeur dans les bornes du NumericUpDown
                decimal nbMensu = demandePret.NombreMensualites;
                if (nbMensu < numNbMensualites.Minimum)
                    nbMensu = numNbMensualites.Minimum;
                else if (nbMensu > numNbMensualites.Maximum)
                    nbMensu = numNbMensualites.Maximum;
                numNbMensualites.Value = nbMensu;
            }
            else if (!cb2_MontantMensualites.Checked)
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

                // Correction : clamp la valeur dans les bornes du NumericUpDown
                decimal montantMensu = demandePret.PrixMensualite;
                if (montantMensu < numMontantMensualites.Minimum)
                    montantMensu = numMontantMensualites.Minimum;
                else if (montantMensu > numMontantMensualites.Maximum)
                    montantMensu = numMontantMensualites.Maximum;
                numMontantMensualites.Value = montantMensu;
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

                // Correction : clamp la valeur dans les bornes du NumericUpDown
                decimal premierApport = demandePret.PremierApport;
                if (premierApport < numPremierApport.Minimum)
                    premierApport = numPremierApport.Minimum;
                else if (premierApport > numPremierApport.Maximum)
                    premierApport = numPremierApport.Maximum;
                numPremierApport.Value = premierApport;
            }

            // Affichage du résultat dans les labels
            lblPrixTotalVehicule.Text = Globales.vehiculeSelectionneVente.Prix.ToString("N2") + " €";
            lblPrixTotal.Text = (Globales.prixTotalAFinancer).ToString("N2") + " €";
            // Vous pouvez aussi afficher les mensualités, le nombre de mensualités, etc. si besoin
            // Par exemple :
            // lblNbMensualites.Text = numNbMensualites.Value.ToString();
            // lblMontantMensualite.Text = numMontantMensualites.Value.ToString("N2") + " €";
            // lblPremierApport.Text = numPremierApport.Value.ToString("N2") + " €";
        }
    }
}
