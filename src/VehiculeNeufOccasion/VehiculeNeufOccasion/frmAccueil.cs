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
        frmLouer louer = new frmLouer();
        frmAcheter acheter = new frmAcheter();
        frmVendre revendre = new frmVendre();
        public Voiture vTemp = new Voiture();

        private void HideAllForms()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Form form)
                {
                    form.Hide();
                }
            }
        }



        public frmAccueil()
        {
            InitializeComponent();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void btnLouer_Click(object sender, EventArgs e)
        {

            //// Configure le formulaire pour qu'il soit un enfant du Panel
            //louer.TopLevel = false; // Indique que ce n'est pas une fenêtre indépendante
            //louer.FormBorderStyle = FormBorderStyle.None; // Supprime la bordure
            //louer.Dock = DockStyle.Fill; // Adapte le formulaire à la taille du Panel

            //// Ajoute le formulaire au Panel
            //panel1.Controls.Add(louer);
            //panel1.Tag = louer;

            if (louer == null || louer.IsDisposed)
            {
                frmLouer louer = new frmLouer();
            }
            if (!panel1.Controls.Contains(louer))
            {
                // Configure le formulaire pour qu'il soit enfant du Panel
                louer.TopLevel = false; // Pas une fenêtre indépendante
                louer.FormBorderStyle = FormBorderStyle.None; // Pas de bordure
                louer.Dock = DockStyle.Fill; // Remplit le Panel

                // Ajoute le formulaire au Panel
                panel1.Controls.Add(louer);
            }

            //Cacher les autres formulaires
            HideAllForms();

            // Affiche le formulaire
            louer.Show();
            acheter.BringToFront();
        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {

            //// Configure le formulaire pour qu'il soit un enfant du Panel
            //acheter.TopLevel = false; // Indique que ce n'est pas une fenêtre indépendante
            //acheter.FormBorderStyle = FormBorderStyle.None; // Supprime la bordure
            //acheter.Dock = DockStyle.Fill; // Adapte le formulaire à la taille du Panel

            //// Ajoute le formulaire au Panel
            //panel1.Controls.Add(acheter);
            //panel1.Tag = acheter;


            if (acheter == null || acheter.IsDisposed)
            {
                frmAcheter acheter = new frmAcheter();
            }
            if (!panel1.Controls.Contains(acheter))
            {
                // Configure le formulaire pour qu'il soit enfant du Panel
                acheter.TopLevel = false; // Pas une fenêtre indépendante
                acheter.FormBorderStyle = FormBorderStyle.None; // Pas de bordure
                acheter.Dock = DockStyle.Fill; // Remplit le Panel

                // Ajoute le formulaire au Panel
                panel1.Controls.Add(acheter);
            }

            //Cacher les autres formulaires
            HideAllForms();

            // Affiche le formulaire
            acheter.BringToFront();
            acheter.Show();
        }

        private void btnRevendre_Click(object sender, EventArgs e)
        {

            if (revendre == null || revendre.IsDisposed)
            {
                frmVendre revendre = new frmVendre();
            }
            if (!panel1.Controls.Contains(revendre))
            {
                // Configure le formulaire pour qu'il soit enfant du Panel
                revendre.TopLevel = false; // Pas une fenêtre indépendante
                revendre.FormBorderStyle = FormBorderStyle.None; // Pas de bordure
                revendre.Dock = DockStyle.Fill; // Remplit le Panel

                // Ajoute le formulaire au Panel
                panel1.Controls.Add(revendre);
            }

            //Cacher les autres formulaires
            HideAllForms();

            // Affiche le formulaire
            revendre.BringToFront();
            revendre.Show();
        }
    }
}
