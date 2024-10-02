using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmIntroduction : Form
    {
        public frmIntroduction()
        {
            InitializeComponent();
            Globales.monNouveauVehicule = new Voiture();
            Globales.monAncienVehicule = new Voiture();
        }

        private void frmIntroduction_Load(object sender, EventArgs e)
        {
            foreach(Vendeur xVendeur in Globales.uneConcession.getLesVendeurs())
            {
                cboVendeur.Items.Add(xVendeur.getInfoVendeur());
            }

            // pour récupérer les infos, repartir de la collection des vendeurs
            // le 2ème de la combobox correspond au deuxième de la collection
            // le combox me sert à récupérer l'index

            // TODO
            // afficher sur tous les écrans le nom du vendeur
            // passage vers une variable globale
            // lblNomVendeur.Text = 
        }

        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            // TODO
            // va stocker les informations de l'écran vers l'objet
            // (ensuite, pas ici, dans la bdd)

            // mettre à jour, l'objet client, voiture, 

            //string affichage = "";
            //affichage = cboCiv.Text + " " + txtNom.Text + " " + txtPrenom.Text;
            //affichage += Environment.NewLine; // saut de ligne
            //affichage += cboVendeur.Text;

            //// âge du véhicule ??
            //// soit les radioboutons
            //// soit avec l'indice for i;
            //// soit avec un while
            //affichage += Environment.NewLine;
            //foreach(RadioButton rdb in gpbAgeV.Controls)
            //{
            //    if (rdb.Checked)
            //    {
            //        affichage += "age : " + rdb.Text;
            //    }
            //}

            // ancien véhicule TODO
            // ..............

            //MessageBox.Show(affichage);

            // TODO
            // un objet voiture ??? dans l'environnement de travail

            // 
            // un objet client ??? ancien TP donc utiliser une référence
            // mais que civilité, nom et prénom 
            // plus tard (numéro client)
            Globales.unClient = new Client(0, cboCiv.Text, txtNom.Text, txtPrenom.Text);

            setLesVoitures(sender);
        }

        private void cboVendeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globales.monVendeur = Globales.uneConcession.getLesVendeurs()[cboVendeur.SelectedIndex];
            lblNomVendeur.Text = Globales.monVendeur.getInfoVendeur();
        }

        private void frmIntroduction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void setLesVoitures(object sender)
        {
            Globales.monNouveauVehicule.setLeNom(txtNouvVhc.Text);
            Globales.monAncienVehicule.setLeNom(txtAncVhc.Text);
        //    if (rdbNeuf.Checked)
        //        Globales.monNouveauVehicule.setLage(Voiture.ageV.neuf);
        //    else if (rdbOccasionMoins3.Checked)
        //        Globales.monNouveauVehicule.setLage(Voiture.ageV.moins3ans);
        //    else if (rdbOccasion3a5.Checked)
        //        Globales.monNouveauVehicule.setLage(Voiture.ageV.de3a5ans);
        //    else
        //        Globales.monNouveauVehicule.setLage(Voiture.ageV.plus5ans);
            foreach(RadioButton c in gpbAgeV.Controls)
            {
                if (c.Checked)
                    Globales.monNouveauVehicule.setLage(c.Text);
            }
        }

        private void cmdVoiture_Click(object sender, EventArgs e)
        {
            //setLesVoitures(sender);
            if(Globales.fenVoiture == null)
                Globales.fenVoiture = new frmVoiture();

            Globales.fenVoiture.Show();
            Globales.fenIntroduction.Hide();
        }

        private void frmIntroduction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Globales.quitter)
            {
                DialogResult result = MessageBox.Show("Fermer l'application sans enregistrer ?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else
                {
                    Globales.quitter = true;
                    Application.Exit();
                }
            }
        }

        private void frmIntroduction_VisibleChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in gpbAgeV.Controls)
            {
                if (Globales.monNouveauVehicule.getLage() == r.Text)
                    r.Checked = true;
            }
            txtNouvVhc.Text = Globales.monNouveauVehicule.getLeNom();
        }
    }
}
