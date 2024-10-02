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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            Globales.fenAccueil = this;
            lblMonApplication.Text = Globales.nomUtilisateur;

            // traiter la concession
            Globales.uneConcession = new Concession();

            lblMonApplication.Text = Globales.nomUtilisateur;

            lblMaRegion.Text = Globales.maRegion;

            Globales.uneConcession = new Concession("Garage Baudouin", "66 rue des Vosges");

            // un vendeur
            Vendeur unVendeur = new Vendeur("Mme", "Baudouin", "Adélia");
            Vendeur un2Vendeur = new Vendeur("Mme", "Hidalgo", "Anne");
            Vendeur un3Vendeur = new Vendeur("M.", "Kalck", "Damien");

            // stocker dans la liste des vendeurs
            // (une manière de faire)
            Globales.uneConcession.ajoutVendeur(unVendeur);
            Globales.uneConcession.ajoutVendeur(un2Vendeur);
            Globales.uneConcession.ajoutVendeur(un3Vendeur);

            // à la place, il faudrait récupérer les informations sur SQLServer
            gestBdd();
        }

        void gestBdd()
        {
            // connexion à la base de données
            // reprendre le tp saisieVendeur
        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            if(Globales.fenIntroduction == null)
                Globales.fenIntroduction = new frmIntroduction();
            
            Globales.fenIntroduction.Show();
            // une seule fenêtre
            // (showdialog)

            // booléen
            // enabled
            // tester si la fenêtre existe déjà ?? == null
            // (un singleton ?? une seule instance)

            //this.Close();

            this.Hide();    // masquer la fenêtre, l'objet courant
        }
    }
}
