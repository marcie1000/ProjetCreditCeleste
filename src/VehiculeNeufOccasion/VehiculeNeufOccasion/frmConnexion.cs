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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
            this.AcceptButton = btnValider;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim().ToLower();
            string mdp = txtMdp.Text;

            try
            {
                using (var cmd = new System.Data.SqlClient.SqlCommand(
                    "SELECT * FROM concession.UTILISATEUR WHERE LOWER(RTRIM(LTRIM(login))) = @login"))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    var dt = Bdd.select(cmd);
                    if (dt.Rows.Count == 1)
                    {
                        string hash = dt.Rows[0]["mdp"].ToString();
                        if (BCrypt.Net.BCrypt.EnhancedVerify(mdp, hash))
                        {
                            // Successful login
                            Globales.UtilisateurConnecte = new Utilisateur
                            {
                                Id = (int)dt.Rows[0]["id"],
                                Login = dt.Rows[0]["login"].ToString(),
                                Mdp = hash,
                                Admin = (bool)dt.Rows[0]["admin_"]
                                // ...set other properties if needed...
                            };
                            MessageBox.Show("Connexion réussie !");
                            // ...proceed to main app...
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe incorrect.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur non trouvé.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
