using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehiculeNeufOccasion
{
    public partial class frmAdministration : Form
    {
        public frmAdministration()
        {
            InitializeComponent();
        }

        private void frmAdministration_Load(object sender, EventArgs e)
        {
            cbTables.Items.AddRange(new string[] { "VEHICULE", "CLIENT", "VENDEUR" });
            cbTables.SelectedIndex = 0;
            LoadTableData();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void LoadTableData()
        {
            string table = cbTables.SelectedItem.ToString();
            string sql = $"SELECT * FROM concession.{table}";
            using (var cmd = new SqlCommand(sql))
            {
                DataTable dt = Bdd.select(cmd);
                dgvData.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string table = cbTables.SelectedItem.ToString();
            switch (table)
            {
                case "VEHICULE":
                    MessageBox.Show("Ajout de véhicule non implémenté ici.");
                    break;
                case "CLIENT":
                    MessageBox.Show("Ajout de client non implémenté ici.");
                    break;
                case "VENDEUR":
                    MessageBox.Show("Ajout de vendeur non implémenté ici.");
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            string table = cbTables.SelectedItem.ToString();
            MessageBox.Show("Modification non implémentée ici.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            string table = cbTables.SelectedItem.ToString();
            DataRowView drv = dgvData.SelectedRows[0].DataBoundItem as DataRowView;
            int id = Convert.ToInt32(drv.Row["id"]);
            if (MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var cmd = new SqlCommand($"DELETE FROM concession.{table} WHERE id=@id"))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    Bdd.insert(cmd);
                }
                LoadTableData();
            }
        }
    }
}
