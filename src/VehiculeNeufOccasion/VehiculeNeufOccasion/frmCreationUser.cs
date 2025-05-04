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
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO UTILISATEUR(login, mdp, admin_) VALUES(@login, @mdp, @admin);";
            SqlCommand commande = new SqlCommand(requete);
            commande.Parameters.AddWithValue("@login", txtLogin.Text);
            commande.Parameters.AddWithValue("@mdp", PasswordHelper.hashPassword(txtMdp.Text));
            commande.Parameters.AddWithValue("@admin", cbAdmin.Checked);
            try
            {
                MessageBox.Show(Bdd.insert(commande) + " lignes affectées.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
