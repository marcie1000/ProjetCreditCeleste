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
    public partial class frmVoiture : Form
    {
        public frmVoiture()
        {
            InitializeComponent();
        }

        private void frmVoiture_Load(object sender, EventArgs e)
        {
            foreach(RadioButton r in gpbAgeVehicule.Controls)
            {
                if (Globales.monNouveauVehicule.getLage() == r.Text)
                    r.Checked = true;
            }
            txtNouvVhc.Text = Globales.monNouveauVehicule.getLeNom();
        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            // retour vers l'introduction TODO
            this.Hide();
            Globales.fenIntroduction.Show();
        }

        private void frmVoiture_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmdEnregistre_Click(object sender, EventArgs e)
        {
            string age = "";
            foreach(RadioButton r in gpbAgeVehicule.Controls)
            {
                if (r.Checked)
                    age = r.Text;
            }
            Globales.monNouveauVehicule.setLaVoiture(txtNouvVhc.Text, dtp1ereImmat.Value, txtNumImmat.Text, txtNumSerie.Text, Convert.ToDouble(txtPuissance.Text), age);
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {

        }
    }
}
