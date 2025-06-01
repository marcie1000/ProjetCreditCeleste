using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehiculeNeufOccasion
{
    public partial class frmChoisirClient : Form
    {
        public frmChoisirClient()
        {
            InitializeComponent();
        }

        private void rechercheEtAffichage(string nom, string prenom)
        {
            if (!LogiqueClients.rechercheClient(nom, prenom))
                return;

            listView1.Items.Clear();

            foreach (Client c in Globales.ClientsRecherche.Values)
            {
                ListViewItem item = new ListViewItem(c.Nom);
                item.SubItems.Add(c.Prenom);
                item.SubItems.Add(c.Email);
                listView1.Items.Add(item);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            rechercheEtAffichage(txtNom.Text, txtPrenom.Text);
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vous devez sélectionner un client.");
                return;
            }

            Globales.clientSelectionne = Globales.ClientsRecherche.Values.ToList()[listView1.SelectedIndices[0]];

            try
            {
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void frmChoisirClient_Load(object sender, EventArgs e)
        {

        }

        private void frmChoisirClient_Shown(object sender, EventArgs e)
        {
            if (Globales.suiteFenetres.getIndexFenetreActuelle() > 0)
                btnRetour.Enabled = true;
            else
                btnRetour.Enabled = false;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Globales.clientEditionValide = false;
            Globales.clientEdition = new Client();
            frmEditClient frm = new frmEditClient();
            frm.ShowDialog();
            if (Globales.clientEditionValide == false)
                return;

            // créer la nouvelle PERSONNE
            string requete = "INSERT INTO concession.PERSONNE default values; SELECT CAST(scope_identity() AS int);";
            int idPersonne = 0;
            using (SqlCommand commande = new SqlCommand(requete))
            {
                try
                {
                    idPersonne = Bdd.insertScalar(commande);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(idPersonne == 0)
            {
                MessageBox.Show("Le client n'a pas pu être inséré.");
                return;
            }
            else
                Globales.clientEdition.IdPersonne = idPersonne;

            // insérer le nouveau CLIENT
            requete = "INSERT INTO concession.CLIENT(prenom, nom, numRue, cp, ville, numTelephone, rue, email, id_personne)" +
                "VALUES(@prenom, @nom, @numRue, @cp, @ville, @numTelephone, @rue, @email, @id_personne)";
            using(SqlCommand commande = new SqlCommand(requete))
            {
                commande.Parameters.AddWithValue("@prenom", Globales.clientEdition.Prenom);
                commande.Parameters.AddWithValue("@nom", Globales.clientEdition.Nom);
                commande.Parameters.AddWithValue("@numRue", Globales.clientEdition.NumRue);
                commande.Parameters.AddWithValue("@cp", Globales.clientEdition.Cp);
                commande.Parameters.AddWithValue("@ville", Globales.clientEdition.Ville);
                commande.Parameters.AddWithValue("@numTelephone", Globales.clientEdition.NumTelephone);
                commande.Parameters.AddWithValue("@rue", Globales.clientEdition.Rue);
                commande.Parameters.AddWithValue("@email", Globales.clientEdition.Email);
                commande.Parameters.AddWithValue("@id_personne", Globales.clientEdition.IdPersonne);

                int result = 0;
                try
                {
                    result = Bdd.insert(commande);
                    if (result != 0)
                        MessageBox.Show("Client ajouté dans la base de données.");
                    else
                    {
                        MessageBox.Show("L'ajout n'a pas fonctionné.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                rechercheEtAffichage(Globales.clientEdition.Nom, Globales.clientEdition.Prenom);
            }


        }
    }
}
