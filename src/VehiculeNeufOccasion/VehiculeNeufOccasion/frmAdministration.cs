using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

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
            var tables = new List<string> { "VEHICULE", "CLIENT", "VENDEUR" };
            if (Globales.UtilisateurConnecte != null && Globales.UtilisateurConnecte.Admin)
                tables.Add("UTILISATEUR");
            cbTables.Items.AddRange(tables.ToArray());
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
                    DialogResult r = MessageBox.Show("Ce véhicule sera ajouté dans les véhicules " +
                        "appartenant au garage.", "Attention", MessageBoxButtons.OKCancel);
                    if(r == DialogResult.OK)
                    {
                        Globales.vehiculeEdition = new Vehicule();
                        Globales.vehiculeEdition.IdPersonnePossession = Globales.LeGarage.IdPersonne;
                        Globales.vehiculeEdition.IdPersonnePossessionNavigation = Globales.LeGarage.IdPersonneNavigation;
                        Globales.vehiculeEdition.Annee = 2010;
                        LogiqueAchats.ajouterVehicule();
                    }
                    break;
                case "CLIENT":
                    LogiqueClients.ajouterClient();
                    break;
                case "VENDEUR":
                    MessageBox.Show("Ajout de vendeur non implémenté ici.");
                    break;
                case "UTILISATEUR":
                    if (Globales.UtilisateurConnecte != null && Globales.UtilisateurConnecte.Admin)
                    {
                        frmCreationUser frm = new frmCreationUser();
                        frm.ForceSizableBorder = true;
                        // Show as dialog and only reload if DialogResult.OK
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadTableData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Accès réservé aux administrateurs.");
                    }
                    break;
            }
            if (table != "UTILISATEUR") // already handled above
                LoadTableData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) 
                return;
            DataRowView drv = dgvData.SelectedRows[0].DataBoundItem as DataRowView;
            string table = cbTables.SelectedItem.ToString();
            switch (table)
            {
                case "CLIENT":
                    Globales.clientEditionValide = false;
                    Globales.clientEdition = new Client();
                    Globales.clientEdition.Id = Convert.ToInt32(drv.Row["id"]);
                    Globales.clientEdition.Prenom = drv.Row["prenom"].ToString();
                    Globales.clientEdition.Nom = drv.Row["nom"].ToString();
                    Globales.clientEdition.NumRue = drv.Row["numRue"].ToString();
                    Globales.clientEdition.Cp = Convert.ToInt32(drv.Row["cp"]);
                    Globales.clientEdition.Ville = drv.Row["ville"].ToString();
                    Globales.clientEdition.NumTelephone = drv.Row["numTelephone"].ToString();
                    Globales.clientEdition.Rue = drv.Row["rue"].ToString();
                    Globales.clientEdition.Email = drv.Row["email"].ToString();
                    Globales.clientEdition.IdPersonne = Convert.ToInt32(drv.Row["id_personne"]);
                    LogiqueClients.updateClient();
                    break;
                case "VEHICULE":
                    Globales.vehiculeEdition = new Vehicule();
                    Globales.vehiculeEditionValide = false;
                    Globales.vehiculeEdition.Annee = (int)drv.Row["annee"];
                    Globales.vehiculeEdition.Kilometrage = (int)drv.Row["kilometrage"];
                    Globales.vehiculeEdition.Prix = (decimal)drv.Row["prix"];
                    Globales.vehiculeEdition.Puissance = (int)drv.Row["puissance"];
                    Globales.vehiculeEdition.Couleur = (string)drv.Row["couleur"];
                    Globales.vehiculeEdition.IdEtat = (int)drv.Row["id_etat"];
                    Globales.vehiculeEdition.IdEtatNavigation = Globales.Etats[Globales.vehiculeEdition.IdEtat];
                    Globales.vehiculeEdition.IdCarburant = (int)drv.Row["id_carburant"];
                    Globales.vehiculeEdition.IdCarburantNavigation = Globales.Carburants[Globales.vehiculeEdition.IdCarburant];
                    Globales.vehiculeEdition.IdModele = (int)drv.Row["id_modele"];
                    Globales.vehiculeEdition.IdModeleNavigation = Globales.Modeles[Globales.vehiculeEdition.IdModele];
                    Globales.vehiculeEdition.IdPersonnePossession = (int)drv.Row["id_personnePossession"];
                    if(Globales.Personnes.ContainsKey(Globales.vehiculeEdition.IdPersonnePossession))
                        Globales.vehiculeEdition.IdPersonnePossessionNavigation = Globales.Personnes[Globales.vehiculeEdition.IdPersonnePossession];
                    Globales.vehiculeEdition.Id = (int)drv.Row["id"];
                    LogiqueAchats.updateVehicule();
                    break;
                case "VENDEUR":
                    MessageBox.Show("Modification de vendeur non implémentée ici.");
                    break;
                case "UTILISATEUR":
                    if (Globales.UtilisateurConnecte != null && Globales.UtilisateurConnecte.Admin)
                    {
                        frmCreationUser frm = new frmCreationUser();
                        frm.ForceSizableBorder = true;
                        // Prefill fields
                        frm.SetUserForEdit(
                            (int)drv.Row["id"],
                            drv.Row["login"].ToString(),
                            drv.Row["mdp"].ToString(),
                            drv.Row.Table.Columns.Contains("admin_") ? (bool)drv.Row["admin_"] : false
                        );
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadTableData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Accès réservé aux administrateurs.");
                    }
                    break;
                default:
                    MessageBox.Show("Modification non implémentée ici.");
                    break;
            }
            if (table != "UTILISATEUR")
                LoadTableData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            string table = cbTables.SelectedItem.ToString();
            DataRowView drv = dgvData.SelectedRows[0].DataBoundItem as DataRowView;
            int id = Convert.ToInt32(drv.Row["id"]);
            if (MessageBox.Show("Confirmer la suppression ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (table == "UTILISATEUR" && (Globales.UtilisateurConnecte == null || !Globales.UtilisateurConnecte.Admin))
                {
                    MessageBox.Show("Suppression d'utilisateur réservée aux administrateurs.");
                    return;
                }
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
