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

        //public void fermerDerniereFenetrePileConteneur()
        //{
        //    panelConteneur.Controls.Clear();
        //    Globales.fenetresConteneur.Last().Close();
        //    Globales.fenetresConteneur.RemoveAt(Globales.fenetresConteneur.Count - 1);
        //    panelConteneur.Controls.Add(Globales.fenetresConteneur.Last());
        //}

        //public void ajouterFenetrePileConteneur(Form fenetre)
        //{
        //    Globales.fenetresConteneur.Add(fenetre);
        //    panelConteneur.Controls.Clear();
        //    panelConteneur.Controls.Add(fenetre);
        //    fenetre.Show();
        //    this.Text = fenetre.Text;
        //}

        /// <summary>
        /// Permet d'afficher une nouvelle fenêtre dans le conteneur de frmAccueil et de fermer l'ancienne affichée.
        /// </summary>
        /// <param name="fenetre"></param>
        //public void changerFenetreDeBaseConteneur(Form fenetre)
        //{
        //    // supprimer l'ancienne fenêtre du conteneur
        //    panelConteneur.Controls.Clear();
            
        //    // fermer l'ancienne fenêtre
        //    for(int i = 0; i < Globales.fenetresConteneur.Count; i++)
        //    {
        //        Globales.fenetresConteneur.Last().Close();
        //    }

        //    Globales.fenetresConteneur.Clear();

        //    // enregistrer dans Globales
        //    Globales.fenetresConteneur.Add(fenetre);

        //    // afficher dans le conteneur
        //    fenetre.Parent = this;
        //    panelConteneur.Controls.Add(fenetre);
        //    fenetre.Show();
        //    this.Text = "Crédit Céleste - " + fenetre.Text;
        //}

        private void cmdAcheter_Click(object sender, EventArgs e)
        {
            try
            {
                frmAcheter nouvelleFen = new frmAcheter() { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.resetSuiteFenetres(this.panelConteneur, this);
                Globales.suiteFenetres.ajouterFenetre(this.panelConteneur, this, nouvelleFen);
                Globales.suiteFenetres.changerFenetreActive(0, this.panelConteneur, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRevendre_Click(object sender, EventArgs e)
        {
            try 
            { 
                frmVendre nouvelleFen = new frmVendre() { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.resetSuiteFenetres(this.panelConteneur, this);
                Globales.suiteFenetres.ajouterFenetre(this.panelConteneur, this, nouvelleFen);
                Globales.suiteFenetres.changerFenetreActive(0, this.panelConteneur, this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdLouer_Click(object sender, EventArgs e)
        {
            try
            {
                frmLouer nouvelleFen = new frmLouer() { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.resetSuiteFenetres(this.panelConteneur, this);
                Globales.suiteFenetres.ajouterFenetre(this.panelConteneur, this, nouvelleFen);
                Globales.suiteFenetres.changerFenetreActive(0, this.panelConteneur, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreerUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreationUser nouvelleFen = new frmCreationUser() { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.resetSuiteFenetres(this.panelConteneur, this);
                Globales.suiteFenetres.ajouterFenetre(this.panelConteneur, this, nouvelleFen);
                Globales.suiteFenetres.changerFenetreActive(0, this.panelConteneur, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            try
            {
                frmConnexion nouvelleFen = new frmConnexion() { TopLevel = false, TopMost = true };
                Globales.suiteFenetres.resetSuiteFenetres(this.panelConteneur, this);
                Globales.suiteFenetres.ajouterFenetre(this.panelConteneur, this, nouvelleFen);
                Globales.suiteFenetres.changerFenetreActive(0, this.panelConteneur, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Globales.panelConteneurAcceuil = this.panelConteneur;
        }

    }
}
