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
    public partial class frmAcheter : Form
    {
        public frmAcheter()
        {
            InitializeComponent();
        }

        private void cmdRetour_Click(object sender, EventArgs e)
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

        private void cbxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmAcheter_Load(object sender, EventArgs e)
        {
            rdbRachat.Checked = true;
            refreshList();
        }

        private void refreshList()
        {
            try
            {
                //lblMessage.Text = "Recherche des véhicules disponibles.";
                //lblMessage.Visible = false;
                LogiqueVente.getLesVehiculesDeLaPersonne(Globales.clientSelectionne.IdPersonne);
                listViewVehicules.Items.Clear();
                foreach (Vehicule v in Globales.Vehicules.Values)
                {
                    ListViewItem item = new ListViewItem(v.IdModeleNavigation.IdMarqueNavigation.Nom);
                    item.SubItems.Add(v.IdModeleNavigation.Nom);
                    item.SubItems.Add(v.Annee.ToString());
                    item.SubItems.Add(v.Kilometrage.ToString());
                    item.SubItems.Add(v.Prix.ToString() + " €");
                    item.SubItems.Add(v.Puissance.ToString());
                    item.SubItems.Add(v.Couleur.ToString());
                    item.SubItems.Add(v.IdCarburantNavigation.Designation);
                    item.SubItems.Add(v.IdEtatNavigation.Designation);
                    item.SubItems.Add(v.Id.ToString());
                    listViewVehicules.Items.Add(item);
                }
                //lblMessage.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdbNeRachetePas_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNeRachetePas.Checked == true)
            {
                listViewVehicules.Items.Clear();
                gpbChoixV.Enabled = false;
            }
            else
            {
                refreshList();
                gpbChoixV.Enabled = true;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if(rdbRachat.Checked)
            {
                if(listViewVehicules.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Vous devez sélectionner un véhicule, ou désactiver le rachat d'un véhicule.");
                    return;
                }

                int id = Convert.ToInt32(listViewVehicules.SelectedItems[0].SubItems[9].Text);
                Globales.vehiculeSelectionneRachat = Globales.Vehicules[id];
            }
            else
            {
                Globales.vehiculeSelectionneRachat = null;
            }

            try
            {
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Globales.vehiculeEdition = new Vehicule();
            Globales.vehiculeEdition.IdPersonnePossession = Globales.clientSelectionne.IdPersonne;
            Globales.vehiculeEdition.IdPersonnePossessionNavigation = Globales.clientSelectionne.IdPersonneNavigation;
            Globales.vehiculeEdition.Annee = 2010;
            LogiqueAchats.ajouterVehicule();
            refreshList();
        }
    }
}
