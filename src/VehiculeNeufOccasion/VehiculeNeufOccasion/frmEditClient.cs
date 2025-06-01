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
    public partial class frmEditClient : Form
    {
        public frmEditClient()
        {
            InitializeComponent();
        }

        public void editTitre(string titre)
        {
            lblTitre.Text = titre;
        }

        private void frmEditClient_Load(object sender, EventArgs e)
        {
            Globales.clientEditionValide = false;
            if (Globales.clientEdition is null)
                Globales.clientEdition = new Client();

            txtNom.Text = Globales.clientEdition.Nom;
            txtPrenom.Text = Globales.clientEdition.Prenom;
            txtNumVoie.Text = Globales.clientEdition.NumRue;
            txtVoie.Text = Globales.clientEdition.Rue;
            txtCodePostal.Text = Globales.clientEdition.Cp.ToString();
            txtVille.Text = Globales.clientEdition.Ville;
            txtTelephone.Text = Globales.clientEdition.NumTelephone;
            txtEmail.Text = Globales.clientEdition.Email;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtNom.Text == "")
            {
                MessageBox.Show("Le nom est obligatoire.");
                return;
            }

            if (txtPrenom.Text == "")
            {
                MessageBox.Show("Le prénom est obligatoire.");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("L'e-mail est obligatoire.");
                return;
            }

            Globales.clientEdition.Nom = txtNom.Text;
            Globales.clientEdition.Prenom = txtPrenom.Text;
            Globales.clientEdition.NumRue = txtNumVoie.Text;
            Globales.clientEdition.Rue = txtVoie.Text;
            if (txtCodePostal.Text == "")
                Globales.clientEdition.Cp = 0;
            else
                Globales.clientEdition.Cp = Convert.ToInt32(txtCodePostal.Text);
            Globales.clientEdition.Ville = txtVille.Text;
            Globales.clientEdition.NumTelephone = txtTelephone.Text;
            Globales.clientEdition.Email = txtEmail.Text;

            Globales.clientEditionValide = true;
            this.Close();
        }
    }
}
