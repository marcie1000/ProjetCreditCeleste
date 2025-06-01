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
    public partial class frmLouer : Form
    {
        public frmLouer()
        {
            InitializeComponent();
        }

        private void frmLouer_Shown(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "Recherche des véhicules disponibles pour location.";
                lblMessage.Visible = false;
                LogiqueVente.getLesVehiculesDuGarage();
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
                    listViewVehicules.Items.Add(item);
                }
                lblMessage.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLouer_Click(object sender, EventArgs e)
        {
            if (listViewVehicules.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un véhicule !");
                return;
            }
            Globales.vehiculeSelectionneLocation = Globales.Vehicules.Values.ToList()[listViewVehicules.SelectedItems[0].Index];

            try
            {
                // Ajoute frmLeasing comme prochaine fenêtre
                frmLeasing fenLeasing = new frmLeasing() { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.ajouterFenetre(Globales.panelConteneurAcceuil, Globales.fenAccueil, fenLeasing);
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            if (Globales.fenAccueil == null)
                Globales.fenAccueil = new frmAccueil();
            Globales.fenAccueil.Show();
            this.Hide();
        }
    }
}
