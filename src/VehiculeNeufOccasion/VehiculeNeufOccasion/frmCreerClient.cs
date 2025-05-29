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
    public partial class frmCreerClient : Form
    {
        public frmCreerClient()
        {
            InitializeComponent();
        }

        private void frmCreerClient_Load(object sender, EventArgs e)
        {
            // Pré-remplir si un client temporaire existe
            if (Globales.ClientTemporaire != null)
            {
                txtNom.Text = Globales.ClientTemporaire.Nom;
                txtPrenom.Text = Globales.ClientTemporaire.Prenom;
                // Les autres champs restent vides pour être complétés
            }
        }

        private void btnClientProvisoire_Click(object sender, EventArgs e)
        {
            // Créer un client temporaire avec nom et prénom uniquement
            var nom = txtNom.Text.Trim();
            var prenom = txtPrenom.Text.Trim();
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Veuillez saisir le nom et le prénom.");
                return;
            }
            Globales.ClientTemporaire = new Client
            {
                Nom = nom,
                Prenom = prenom
                // Les autres champs restent vides ou null
            };
            MessageBox.Show("Client provisoire créé. Vous pouvez compléter les informations plus tard.");
        }

        private void btnCreerClient_Click(object sender, EventArgs e)
        {
            // Récupérer les infos du formulaire (pré-remplies ou saisies)
            var nom = txtNom.Text.Trim();
            var prenom = txtPrenom.Text.Trim();
            var rue = txtRue.Text.Trim();
            var numRue = txtNumRue.Text.Trim();
            var ville = txtVille.Text.Trim();
            var email = txtEmail.Text.Trim();
            var numTelephone = txtNumTel.Text.Trim();
            int cp = 0;
            int.TryParse(txtCp.Text.Trim(), out cp);

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Nom et prénom obligatoires.");
                return;
            }

            // Création du client dans la base
            try
            {
                // Insérer dans la table PERSONNE d'abord si besoin
                int idPersonne = 0;
                using (var cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO concession.PERSONNE DEFAULT VALUES; SELECT SCOPE_IDENTITY();"))
                {
                    var dt = Bdd.select(cmd);
                    if (dt.Rows.Count > 0)
                        idPersonne = Convert.ToInt32(dt.Rows[0][0]);
                }

                // Insérer dans la table CLIENT
                using (var cmd = new System.Data.SqlClient.SqlCommand(
                    "INSERT INTO concession.CLIENT (id_personne, nom, prenom, rue, numRue, cp, ville, numTelephone, email) " +
                    "VALUES (@id_personne, @nom, @prenom, @rue, @numRue, @cp, @ville, @numTelephone, @email); SELECT SCOPE_IDENTITY();"))
                {
                    cmd.Parameters.AddWithValue("@id_personne", idPersonne);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@rue", rue);
                    cmd.Parameters.AddWithValue("@numRue", numRue);
                    cmd.Parameters.AddWithValue("@cp", cp);
                    cmd.Parameters.AddWithValue("@ville", ville);
                    cmd.Parameters.AddWithValue("@numTelephone", numTelephone);
                    cmd.Parameters.AddWithValue("@email", email);

                    var dt = Bdd.select(cmd);
                    int idClient = 0;
                    if (dt.Rows.Count > 0)
                        idClient = Convert.ToInt32(dt.Rows[0][0]);

                    // Créer l'objet client et l'ajouter à Globales
                    var client = new Client
                    {
                        Id = idClient,
                        IdPersonne = idPersonne,
                        Nom = nom,
                        Prenom = prenom,
                        Rue = rue,
                        NumRue = numRue,
                        Cp = cp,
                        Ville = ville,
                        NumTelephone = numTelephone,
                        Email = email
                    };
                    Globales.ClientsRecherche[client.Id] = client;
                    Globales.clientSelectionne = client;
                    Globales.ClientTemporaire = null; // On n'a plus besoin du client temporaire

                    MessageBox.Show("Client créé avec succès !");
                    // Remove this window from the navigation stack and advance to the next
                    int idx = Globales.suiteFenetres.getIndexFenetreActuelle();
                    if (idx >= 0 && idx < Globales.suiteFenetres.listeFenetres.Count &&
                        Globales.suiteFenetres.listeFenetres[idx] == this)
                    {
                        Globales.suiteFenetres.listeFenetres.RemoveAt(idx);
                        // After removing, show the next window (which should be frmAcheter or frmProposerCredit)
                        Globales.suiteFenetres.changerFenetreActive(idx, Globales.panelConteneurAcceuil, Globales.fenAccueil);
                    }
                    else
                    {
                        // Fallback: just try to show the next window
                        Globales.suiteFenetres.afficherFenetreSuivante(Globales.panelConteneurAcceuil, Globales.fenAccueil);
                    }
                    // Optionally: this.Close(); // Not needed, handled by navigation
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du client : " + ex.Message);
            }
        }

        private void btnChoisirClient_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = Globales.suiteFenetres.getIndexFenetreActuelle();
                if (idx >= 0 && idx < Globales.suiteFenetres.listeFenetres.Count &&
                    Globales.suiteFenetres.listeFenetres[idx] == this)
                {
                    Globales.suiteFenetres.listeFenetres.RemoveAt(idx);
                    Globales.suiteFenetres.changerFenetreActive(idx - 1, Globales.panelConteneurAcceuil, Globales.fenAccueil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
