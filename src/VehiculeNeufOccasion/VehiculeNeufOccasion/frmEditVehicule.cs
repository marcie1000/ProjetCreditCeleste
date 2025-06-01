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
    public partial class frmEditVehicule : Form
    {
        public frmEditVehicule()
        {
            InitializeComponent();
        }

        public void editTitre(string titre)
        {
            lblTitre.Text = titre;
        }

        private void frmEditVehicule_Load(object sender, EventArgs e)
        {
            if (Globales.vehiculeEdition is null)
                Globales.vehiculeEdition = new Vehicule();

            Globales.vehiculeEditionValide = false;

            cbxModele.Enabled = false;
            numAnnee.Value = 2010;
            foreach(Marque m in Globales.Marques.Values)
            {
                cbxMarque.Items.Add(m.Nom);
            }

            foreach(Carburant c in Globales.Carburants.Values)
            {
                cbxCarburant.Items.Add(c.Designation);
            }

            foreach(Etat et in Globales.Etats.Values)
            {
                cbxEtat.Items.Add(et.Designation);
            }


            numAnnee.Value = Globales.vehiculeEdition.Annee;
            txtCouleur.Text = Globales.vehiculeEdition.Couleur;
            if (Globales.vehiculeEdition.IdCarburantNavigation is null)
                cbxCarburant.SelectedIndex = 0;
            else
                cbxCarburant.SelectedItem = Globales.vehiculeEdition.IdCarburantNavigation.Designation;

            if (Globales.vehiculeEdition.IdEtatNavigation is null)
                cbxEtat.SelectedIndex = 0;
            else
                cbxEtat.SelectedItem = Globales.vehiculeEdition.IdEtatNavigation.Designation;

            if (Globales.vehiculeEdition.IdModeleNavigation != null)
            {
                cbxMarque.SelectedItem = Globales.vehiculeEdition.IdModeleNavigation.IdMarqueNavigation.Nom;
                cbxModele.SelectedItem = Globales.vehiculeEdition.IdModeleNavigation.Nom;
            }

            numKilometrage.Value = Globales.vehiculeEdition.Kilometrage;
            numPrix.Value = Globales.vehiculeEdition.Prix;
            numPuissance.Value = Globales.vehiculeEdition.Puissance;
        }

        private void cbxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModele.Items.Clear();
            if(cbxMarque.SelectedIndex == -1)
            {
                cbxModele.Enabled = false;
                return;
            }
            Marque selectedMarque = Globales.MarquesParNom[cbxMarque.SelectedItem.ToString()];

            foreach(Modele mod in selectedMarque.Modeles)
            {
                cbxModele.Items.Add(mod.Nom);
            }
            cbxModele.Enabled = true;
            // sélection des modèles concernée par la marque

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbxMarque.SelectedIndex == -1)
            {
                MessageBox.Show("Marque obligatoire.");
                return;
            }
            if (cbxCarburant.SelectedIndex == -1)
            {
                MessageBox.Show("Carburant obligatoire.");
                return;
            }
            if (cbxEtat.SelectedIndex == -1)
            {
                MessageBox.Show("État obligatoire.");
                return;
            }
            if (cbxModele.SelectedIndex == -1)
            {
                MessageBox.Show("Modèle obligatoire.");
                return;
            }

            Globales.vehiculeEdition.Annee = (int)numAnnee.Value;
            Globales.vehiculeEdition.Couleur = txtCouleur.Text;
            Globales.vehiculeEdition.IdCarburant = Globales.CarburantsParNom[cbxCarburant.SelectedItem.ToString()].Id;
            Globales.vehiculeEdition.IdCarburantNavigation = Globales.CarburantsParNom[cbxCarburant.SelectedItem.ToString()];
            Globales.vehiculeEdition.IdEtat = Globales.EtatsParNom[cbxEtat.SelectedItem.ToString()].Id;
            Globales.vehiculeEdition.IdEtatNavigation = Globales.EtatsParNom[cbxEtat.SelectedItem.ToString()];

            Marque selectedMarque = Globales.MarquesParNom[cbxMarque.SelectedItem.ToString()];
            foreach (Modele m in selectedMarque.Modeles)
            {
                if(m.Nom == cbxModele.SelectedItem.ToString())
                {
                    Globales.vehiculeEdition.IdModele = m.Id;
                    Globales.vehiculeEdition.IdModeleNavigation = m;
                    break;
                }
            }
            Globales.vehiculeEdition.Kilometrage = (int)numKilometrage.Value;
            Globales.vehiculeEdition.Prix = numPrix.Value;
            Globales.vehiculeEdition.Puissance = (int)numPuissance.Value;

            Globales.vehiculeEditionValide = true;
            Close();
        }
    }
}
