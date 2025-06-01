using System;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    public partial class frmRecapitulatif : Form
    {
        private Vehicule vehicule;
        private Client client;
        private Vendeur vendeur;
        private decimal montantTotal;
        private decimal prixVehicule;
        private bool isVente; // true = vente, false = location

        private Label lblVehiculeTitle, lblClient, lblVendeur, lblTransaction;
        private CheckBox chkValidation;
        private Button btnConfirmer, btnAccueil;

        public frmRecapitulatif()
        {
            InitializeComponent();
            InitRecap();
        }

        public frmRecapitulatif(Vehicule v, Client c, Vendeur vend, decimal montant, decimal prix, bool vente)
        {
            InitializeComponent();
            vehicule = v;
            client = c;
            vendeur = vend;
            montantTotal = montant;
            prixVehicule = prix;
            isVente = vente;
            InitRecap();
        }

        private void InitRecap()
        {
            this.Controls.Clear();
            this.Text = "Récapitulatif de la transaction";
            this.Width = 800;
            this.Height = 600;

            int y = 20;

            // Véhicule
            lblVehiculeTitle = new Label();
            lblVehiculeTitle.AutoSize = true;
            lblVehiculeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lblVehiculeTitle.Text = "Véhicule :";
            lblVehiculeTitle.Location = new System.Drawing.Point(30, y);
            this.Controls.Add(lblVehiculeTitle);

            y += 30;
            var vehiculeInfo = new Label();
            vehiculeInfo.AutoSize = true;
            vehiculeInfo.Location = new System.Drawing.Point(50, y);
            if (vehicule != null)
            {
                vehiculeInfo.Text = $"ID: {vehicule.Id} | Marque: {vehicule.IdModeleNavigation?.IdMarqueNavigation?.Nom} | Modèle: {vehicule.IdModeleNavigation?.Nom} | Prix: {vehicule.Prix:C} | Couleur: {vehicule.Couleur}";
            }
            else
            {
                vehiculeInfo.Text = "Aucun véhicule sélectionné.";
            }
            this.Controls.Add(vehiculeInfo);

            // Client
            y += 40;
            lblClient = new Label();
            lblClient.AutoSize = true;
            lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lblClient.Text = "Client :";
            lblClient.Location = new System.Drawing.Point(30, y);
            this.Controls.Add(lblClient);

            y += 30;
            var clientInfo = new Label();
            clientInfo.AutoSize = true;
            clientInfo.Location = new System.Drawing.Point(50, y);
            if (client != null)
            {
                clientInfo.Text = $"ID: {client.Id} | Nom: {client.Nom} | Prénom: {client.Prenom} | Adresse: {client.NumRue} {client.Rue}, {client.Cp} {client.Ville} | Tél: {client.NumTelephone} | Email: {client.Email}";
            }
            else
            {
                clientInfo.Text = "Aucun client sélectionné.";
            }
            this.Controls.Add(clientInfo);

            // Vendeur
            y += 40;
            lblVendeur = new Label();
            lblVendeur.AutoSize = true;
            lblVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lblVendeur.Text = "Vendeur :";
            lblVendeur.Location = new System.Drawing.Point(30, y);
            this.Controls.Add(lblVendeur);

            y += 30;
            var vendeurInfo = new Label();
            vendeurInfo.AutoSize = true;
            vendeurInfo.Location = new System.Drawing.Point(50, y);
            if (vendeur != null)
            {
                vendeurInfo.Text = $"Nom: {vendeur.Nom} | Prénom: {vendeur.Prenom}";
            }
            else
            {
                vendeurInfo.Text = "Aucun vendeur sélectionné.";
            }
            this.Controls.Add(vendeurInfo);

            // Transaction
            y += 40;
            lblTransaction = new Label();
            lblTransaction.AutoSize = true;
            lblTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lblTransaction.Text = "Transaction :";
            lblTransaction.Location = new System.Drawing.Point(30, y);
            this.Controls.Add(lblTransaction);

            y += 30;
            var transactionInfo = new Label();
            transactionInfo.AutoSize = true;
            transactionInfo.Location = new System.Drawing.Point(50, y);
            transactionInfo.Text = $"Montant total : {montantTotal:C} | Prix du véhicule : {prixVehicule:C}";
            this.Controls.Add(transactionInfo);

            // Validation
            y += 50;
            chkValidation = new CheckBox();
            chkValidation.Text = "Je valide l'achat / location";
            chkValidation.Location = new System.Drawing.Point(30, y);
            chkValidation.AutoSize = true;
            this.Controls.Add(chkValidation);

            // Boutons
            y += 40;
            btnConfirmer = new Button();
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.Location = new System.Drawing.Point(30, y);
            btnConfirmer.Click += BtnConfirmer_Click;
            this.Controls.Add(btnConfirmer);

            btnAccueil = new Button();
            btnAccueil.Text = "Accueil";
            btnAccueil.Location = new System.Drawing.Point(150, y);
            btnAccueil.Click += BtnAccueil_Click;
            this.Controls.Add(btnAccueil);
        }

        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            if (!chkValidation.Checked)
            {
                MessageBox.Show("Veuillez valider l'achat/la location en cochant la case.");
                return;
            }

            try
            {
                if (isVente)
                {
                    // Enregistrement de la vente
                    using (var cmd = new System.Data.SqlClient.SqlCommand(
                        "INSERT INTO concession.VENTE (dateV, montant, validee, id_garage, id_client, id_vehicule) VALUES (@dateV, @montant, @validee, @id_garage, @id_client, @id_vehicule)"))
                    {
                        cmd.Parameters.AddWithValue("@dateV", DateTime.Now);
                        cmd.Parameters.AddWithValue("@montant", montantTotal);
                        cmd.Parameters.AddWithValue("@validee", true);
                        cmd.Parameters.AddWithValue("@id_garage", Globales.LeGarage.Id);
                        cmd.Parameters.AddWithValue("@id_client", client.Id);
                        cmd.Parameters.AddWithValue("@id_vehicule", vehicule.Id);
                        Bdd.insert(cmd);
                    }
                    MessageBox.Show("Vente enregistrée !");
                }
                else
                {
                    // Enregistrement de la location
                    using (var cmd = new System.Data.SqlClient.SqlCommand(
                        "INSERT INTO concession.LESLOCATION (dateL, montant, id_client, id_vehicule) VALUES (@dateL, @montant, @id_client, @id_vehicule)"))
                    {
                        cmd.Parameters.AddWithValue("@dateL", DateTime.Now);
                        cmd.Parameters.AddWithValue("@montant", montantTotal);
                        cmd.Parameters.AddWithValue("@id_client", client.Id);
                        cmd.Parameters.AddWithValue("@id_vehicule", vehicule.Id);
                        Bdd.insert(cmd);
                    }
                    MessageBox.Show("Location enregistrée !");
                }
                BtnAccueil_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            if (Globales.fenAccueil == null)
                Globales.fenAccueil = new frmAccueil();
            Globales.fenAccueil.Show();
            this.Close();
        }
    }
}
