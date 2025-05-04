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
    public partial class frmVendre : Form
    {
        public frmVendre()
        {
            InitializeComponent();
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            if (Globales.fenAccueil == null)
                Globales.fenAccueil = new frmAccueil();
            Globales.fenAccueil.Show();
            this.Hide();  // masquer la fenêtre, l'objet courant
        }

        private void frmVendre_Shown(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "Recherche des véhicules disponibles.";
                lblMessage.Visible = false;
                LogiqueVente.getLesVehiculesDuGarage();
                listViewVehicules.Items.Clear();
                foreach(Vehicule v in Globales.Vehicules.Values)
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
    }
}
