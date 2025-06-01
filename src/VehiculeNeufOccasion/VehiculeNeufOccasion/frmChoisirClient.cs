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
            // Enable/disable the button for client temporaire if needed
            if (btnClientTemporaire != null)
                btnClientTemporaire.Enabled = Globales.ClientTemporaire != null;
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

            // Propose ClientTemporaire if it exists and is not already in the list
            if (Globales.ClientTemporaire != null)
            {
                bool dejaDansListe = Globales.ClientsRecherche.Values.Any(c =>
                    c.Nom == Globales.ClientTemporaire.Nom &&
                    c.Prenom == Globales.ClientTemporaire.Prenom);

                if (!dejaDansListe)
                {
                    ListViewItem tempItem = new ListViewItem(Globales.ClientTemporaire.Nom + " (provisoire)");
                    tempItem.SubItems.Add(Globales.ClientTemporaire.Prenom);
                    tempItem.SubItems.Add(""); // No email for temp client
                    tempItem.ForeColor = Color.DarkOrange;
                    tempItem.Tag = "temporaire";
                    listView1.Items.Add(tempItem);
                }
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

            var selectedItem = listView1.SelectedItems[0];
            if (selectedItem.Tag != null && selectedItem.Tag.ToString() == "temporaire")
            {
                // User selected the temporary client
                Globales.clientSelectionne = Globales.ClientTemporaire;
            }
            else
            {
                Globales.clientSelectionne = Globales.ClientsRecherche.Values.ToList()[listView1.SelectedIndices[0]];
            }

            try
            {
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Add this method for the new button
        private void btnClientTemporaire_Click(object sender, EventArgs e)
        {
            if (Globales.ClientTemporaire == null)
            {
                MessageBox.Show("Aucun client provisoire n'est disponible.");
                return;
            }
            Globales.clientSelectionne = Globales.ClientTemporaire;
            try
            {
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
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
            // Enable/disable the button for client temporaire if needed
            if (btnClientTemporaire != null)
                btnClientTemporaire.Enabled = Globales.ClientTemporaire != null;
        }

        private void frmChoisirClient_Shown(object sender, EventArgs e)
        {
            if (Globales.suiteFenetres.getIndexFenetreActuelle() > 0)
                btnRetour.Enabled = true;
            else
                btnRetour.Enabled = false;

            // Enable/disable the button for client temporaire if needed
            if (btnClientTemporaire != null)
                btnClientTemporaire.Enabled = Globales.ClientTemporaire != null;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
                if(LogiqueClients.ajouterClient())
                    rechercheEtAffichage(Globales.clientEdition.Nom, Globales.clientEdition.Prenom);
        }
    }
}
