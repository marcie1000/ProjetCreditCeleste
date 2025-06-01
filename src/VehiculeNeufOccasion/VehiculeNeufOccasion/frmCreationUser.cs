using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehiculeNeufOccasion
{
    public partial class frmCreationUser : Form
    {
        public frmCreationUser()
        {
            InitializeComponent();
            this.AcceptButton = btnValider;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim().ToLower();
            string requete = "INSERT INTO concession.UTILISATEUR(login, mdp, admin_) VALUES(@login, @mdp, @admin);";
            SqlCommand commande = new SqlCommand(requete);
            commande.Parameters.AddWithValue("@login", login);
            commande.Parameters.AddWithValue("@mdp", PasswordHelper.hashPassword(txtMdp.Text));
            commande.Parameters.AddWithValue("@admin", cbAdmin.Checked);
            try
            {
                // Check if login already exists
                using (var checkCmd = new SqlCommand("SELECT COUNT(*) FROM concession.UTILISATEUR WHERE LOWER(RTRIM(LTRIM(login))) = @login"))
                {
                    checkCmd.Parameters.AddWithValue("@login", login);
                    var dtCheck = Bdd.select(checkCmd);
                    if (dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                    {
                        MessageBox.Show("Ce login existe déjà. Veuillez en choisir un autre.");
                        return;
                    }
                }

                int affected = Bdd.insert(commande);
                MessageBox.Show(affected + " lignes affectées.");

                // Debug: show all users after insert
                using (var checkCmd = new SqlCommand("SELECT login FROM concession.UTILISATEUR;"))
                {
                    var dt = Bdd.select(checkCmd);
                    string users = string.Join(", ", dt.AsEnumerable().Select(r => r["login"].ToString()));
                    MessageBox.Show("Utilisateurs en base: " + users);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
