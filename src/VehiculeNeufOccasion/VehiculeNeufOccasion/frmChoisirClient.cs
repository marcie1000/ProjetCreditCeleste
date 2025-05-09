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
    public partial class frmChoisirClient : Form
    {
        public frmChoisirClient()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (!LogiqueClients.rechercheClient(txtNom.Text, txtPrenom.Text))
                return;

            listView1.Items.Clear();

            foreach(Client c in Globales.ClientsRecherche.Values)
            {
                ListViewItem item = new ListViewItem(c.Nom);
                item.SubItems.Add(c.Prenom);
                item.SubItems.Add(c.Email);
                listView1.Items.Add(item);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
