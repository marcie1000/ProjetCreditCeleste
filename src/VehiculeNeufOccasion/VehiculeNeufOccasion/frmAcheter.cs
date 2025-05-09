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
            try
            {
                Globales.suiteFenetres.afficherFenetrePrecedente(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmAcheter_Load(object sender, EventArgs e)
        {
            rdbRachat.Checked = true;
        }

        private void rdbNeRachetePas_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbNeRachetePas.Checked == true)
            {
                groupBoxInformations.Enabled = false;
            }
            else
            {
                groupBoxInformations.Enabled = true;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            try
            {
                Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
