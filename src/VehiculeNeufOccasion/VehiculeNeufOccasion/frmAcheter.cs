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
            if (Globales.fenAccueil == null)
                Globales.fenAccueil = new frmAccueil();
            Globales.fenAccueil.Show();
            this.Hide();  // masquer la fenêtre, l'objet courant
        }
    }
}
