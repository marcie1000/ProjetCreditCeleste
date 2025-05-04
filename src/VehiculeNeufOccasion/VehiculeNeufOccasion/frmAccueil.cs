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

        private void cmdAcheter_Click(object sender, EventArgs e)
        {
            if (Globales.fenAcheter == null)
                Globales.fenAcheter = new frmAcheter();
            Globales.fenAcheter.Show();
            this.Hide();  // masquer la fenêtre, l'objet courant 

        }

        private void cmdRevendre_Click(object sender, EventArgs e)
        {
            if (Globales.fenVendre == null)
                Globales.fenVendre = new frmVendre();
            Globales.fenVendre.Show();
            this.Hide();  // masquer la fenêtre, l'objet courant 

        }

        private void cmdLouer_Click(object sender, EventArgs e)
        {
            if (Globales.fenLouer == null)
                Globales.fenLouer = new frmLouer();
            Globales.fenLouer.Show();
            this.Hide();  // masquer la fenêtre, l'objet courant 

        }

        private void btnCreerUser_Click(object sender, EventArgs e)
        {
            if (Globales.fenCreerUser == null)
                Globales.fenCreerUser = new frmCreationUser();
            Globales.fenCreerUser.Show();
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            gpbCompte.Visible = false;
            gpbCompte.Enabled = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }
    }
}
