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
    public partial class frmCompte : Form
    {
        public frmCompte()
        {
            InitializeComponent();
            this.AcceptButton = btnSave;
        }

        private void frmCompte_Load(object sender, EventArgs e)
        {
            if (Globales.UtilisateurConnecte == null)
            {
                MessageBox.Show("Aucun utilisateur connecté.");
                this.Close();
                return;
            }

            txtLogin.Text = Globales.UtilisateurConnecte.Login;
            txtLogin.Enabled = false; // login is not editable
            cbAdmin.Checked = Globales.UtilisateurConnecte.Admin;
            cbAdmin.Enabled = Globales.UtilisateurConnecte.Admin; // only editable if admin
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != "" || txtConfirmPassword.Text != "")
            {
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas.");
                    return;
                }
                // Update password
                try
                {
                    string hash = PasswordHelper.hashPassword(txtNewPassword.Text);
                    using (var cmd = new System.Data.SqlClient.SqlCommand(
                        "UPDATE concession.UTILISATEUR SET mdp = @mdp WHERE id = @id"))
                    {
                        cmd.Parameters.AddWithValue("@mdp", hash);
                        cmd.Parameters.AddWithValue("@id", Globales.UtilisateurConnecte.Id);
                        Bdd.insert(cmd);
                    }
                    Globales.UtilisateurConnecte.Mdp = hash;
                    MessageBox.Show("Mot de passe mis à jour.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du mot de passe : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Aucune modification à enregistrer.");
            }
        }
    }
}
