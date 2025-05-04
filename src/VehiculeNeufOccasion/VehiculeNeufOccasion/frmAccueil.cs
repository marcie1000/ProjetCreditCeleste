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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet d'afficher une nouvelle fenêtre dans le conteneur de frmAccueil et de fermer l'ancien affiché.
        /// </summary>
        /// <param name="fenetre"></param>
        public void changerFenetreConteneur(Form fenetre)
        {
            // supprimer l'ancienne fenêtre du conteneur
            panelConteneur.Controls.Clear();
            
            // fermer l'ancienne fenêtre
            Form ancienneFenetre;
            if (Globales.fenetreConteneur != null)
            {
                ancienneFenetre = Globales.fenetreConteneur;
                ancienneFenetre.Close();
                Globales.fenetreConteneur.Dispose();
                Globales.fenetreConteneur = null;
            }

            // enregistrer dans Globales
            Globales.fenetreConteneur = fenetre;

            // afficher dans le conteneur
            fenetre.Parent = this;
            panelConteneur.Controls.Add(fenetre);
            fenetre.Show();
            this.Text = fenetre.Text;
        }

        private void cmdAcheter_Click(object sender, EventArgs e)
        {
            frmAcheter nouvelleFen = new frmAcheter() { TopLevel = false, TopMost = true };
            changerFenetreConteneur(nouvelleFen);
        }

        private void cmdRevendre_Click(object sender, EventArgs e)
        {
            frmVendre nouvelleFen = new frmVendre() { TopLevel = false, TopMost = true };
            changerFenetreConteneur(nouvelleFen);
            //this.Hide();  // masquer la fenêtre, l'objet courant 
        }

        private void cmdLouer_Click(object sender, EventArgs e)
        {
            frmLouer nouvelleFen = new frmLouer() { TopLevel = false, TopMost = true };
            changerFenetreConteneur(nouvelleFen);
        }

        private void btnCreerUser_Click(object sender, EventArgs e)
        {
            frmCreationUser nouvelleFen = new frmCreationUser() { TopLevel = false, TopMost = true };
            changerFenetreConteneur(nouvelleFen);
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            
        }

    }
}
