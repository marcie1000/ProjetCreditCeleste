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
        private int? userIdEdit = null;
        private string originalLogin = null;

        public bool ForceSizableBorder { get; set; } = false;

        public frmCreationUser()
        {
            InitializeComponent();
            this.AcceptButton = btnValider;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (ForceSizableBorder)
                this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        // Call this before ShowDialog to edit an existing user
        public void SetUserForEdit(int id, string login, string mdp, bool admin)
        {
            userIdEdit = id;
            originalLogin = login;
            txtLogin.Text = login;
            txtLogin.Enabled = false; // login should not be changed
            txtMdp.Text = ""; // don't show password
            cbAdmin.Checked = admin;
            this.Text = "Modifier un utilisateur";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim().ToLower();
            bool isEdit = userIdEdit.HasValue;
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Le login est obligatoire.");
                return;
            }

            if (!isEdit && string.IsNullOrEmpty(txtMdp.Text))
            {
                MessageBox.Show("Le mot de passe est obligatoire.");
                return;
            }

            try
            {
                if (!isEdit)
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
                    string requete = "INSERT INTO concession.UTILISATEUR(login, mdp, admin_) VALUES(@login, @mdp, @admin);";
                    SqlCommand commande = new SqlCommand(requete);
                    commande.Parameters.AddWithValue("@login", login);
                    commande.Parameters.AddWithValue("@mdp", PasswordHelper.hashPassword(txtMdp.Text));
                    commande.Parameters.AddWithValue("@admin", cbAdmin.Checked);

                    int affected = Bdd.insert(commande);
                    if (affected > 0)
                    {
                        MessageBox.Show("Utilisateur ajouté.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    // Edit mode: update password if filled, and admin status
                    string updateSql = "UPDATE concession.UTILISATEUR SET admin_ = @admin";
                    if (!string.IsNullOrEmpty(txtMdp.Text))
                        updateSql += ", mdp = @mdp";
                    updateSql += " WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(updateSql);
                    cmd.Parameters.AddWithValue("@admin", cbAdmin.Checked);
                    cmd.Parameters.AddWithValue("@id", userIdEdit.Value);
                    if (!string.IsNullOrEmpty(txtMdp.Text))
                        cmd.Parameters.AddWithValue("@mdp", PasswordHelper.hashPassword(txtMdp.Text));
                    int affected = Bdd.insert(cmd);
                    if (affected > 0)
                    {
                        MessageBox.Show("Utilisateur modifié.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
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
