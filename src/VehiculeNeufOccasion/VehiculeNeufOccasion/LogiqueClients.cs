using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace VehiculeNeufOccasion
{
    public static class LogiqueClients
    {
        public static bool updateClient()
        {
            bool valeurRetour = false;

            Globales.clientEditionValide = false;
            frmEditClient frm = new frmEditClient();
            frm.editTitre("Modifier le client");
            frm.ShowDialog();
            if (Globales.clientEditionValide == false)
                return valeurRetour;

            // update le CLIENT
            string requete = "UPDATE concession.CLIENT SET prenom = @prenom, nom = @nom, " +
                "numRue = @numRue, cp = @cp, ville = @ville, numTelephone = @numTelephone, " +
                "rue = @rue, email = @email, id_personne = @id_personne " +
                "WHERE id = @id;";
            using (SqlCommand commande = new SqlCommand(requete))
            {
                commande.Parameters.AddWithValue("@prenom", Globales.clientEdition.Prenom);
                commande.Parameters.AddWithValue("@nom", Globales.clientEdition.Nom);
                commande.Parameters.AddWithValue("@numRue", Globales.clientEdition.NumRue);
                commande.Parameters.AddWithValue("@cp", Globales.clientEdition.Cp);
                commande.Parameters.AddWithValue("@ville", Globales.clientEdition.Ville);
                commande.Parameters.AddWithValue("@numTelephone", Globales.clientEdition.NumTelephone);
                commande.Parameters.AddWithValue("@rue", Globales.clientEdition.Rue);
                commande.Parameters.AddWithValue("@email", Globales.clientEdition.Email);
                commande.Parameters.AddWithValue("@id_personne", Globales.clientEdition.IdPersonne);
                commande.Parameters.AddWithValue("@id", Globales.clientEdition.Id);
                int result = 0;
                try
                {
                    result = Bdd.insert(commande);
                    if (result != 0)
                        MessageBox.Show("Client modifié dans la base de données.");
                    else
                    {
                        MessageBox.Show("La modification n'a pas fonctionné.");
                        return valeurRetour;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return valeurRetour;
                }
            }

            return true;
        }
        public static bool ajouterClient()
        {
            bool valeurRetour = false;

            Globales.clientEdition = new Client();
            
            Globales.clientEditionValide = false;
            frmEditClient frm = new frmEditClient();
            frm.ShowDialog();
            if (Globales.clientEditionValide == false)
                return valeurRetour;

            // créer la nouvelle PERSONNE
            string requete = "INSERT INTO concession.PERSONNE default values; SELECT CAST(scope_identity() AS int);";
            int idPersonne = 0;
            using (SqlCommand commande = new SqlCommand(requete))
            {
                try
                {
                    idPersonne = Bdd.insertScalar(commande);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (idPersonne == 0)
            {
                MessageBox.Show("Le client n'a pas pu être inséré.");
                return valeurRetour;
            }
            else
                Globales.clientEdition.IdPersonne = idPersonne;

            // insérer le nouveau CLIENT
            requete = "INSERT INTO concession.CLIENT(prenom, nom, numRue, cp, ville, numTelephone, rue, email, id_personne)" +
                "VALUES(@prenom, @nom, @numRue, @cp, @ville, @numTelephone, @rue, @email, @id_personne)";
            using (SqlCommand commande = new SqlCommand(requete))
            {
                commande.Parameters.AddWithValue("@prenom", Globales.clientEdition.Prenom);
                commande.Parameters.AddWithValue("@nom", Globales.clientEdition.Nom);
                commande.Parameters.AddWithValue("@numRue", Globales.clientEdition.NumRue);
                commande.Parameters.AddWithValue("@cp", Globales.clientEdition.Cp);
                commande.Parameters.AddWithValue("@ville", Globales.clientEdition.Ville);
                commande.Parameters.AddWithValue("@numTelephone", Globales.clientEdition.NumTelephone);
                commande.Parameters.AddWithValue("@rue", Globales.clientEdition.Rue);
                commande.Parameters.AddWithValue("@email", Globales.clientEdition.Email);
                commande.Parameters.AddWithValue("@id_personne", Globales.clientEdition.IdPersonne);

                int result = 0;
                try
                {
                    result = Bdd.insert(commande);
                    if (result != 0)
                        MessageBox.Show("Client ajouté dans la base de données.");
                    else
                    {
                        MessageBox.Show("L'ajout n'a pas fonctionné.");
                        return valeurRetour;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return valeurRetour;
                }
            }
            return true;
        }

        public static bool rechercheClient(string nom, string prenom)
        {
            bool reussite = true;
            Globales.ClientsRecherche.Clear();

            try
            {
                DataTable result;
                using(SqlCommand commande = new SqlCommand("SELECT * FROM concession.CLIENT WHERE " +
                    "nom like CONCAT('%', @nom, '%') AND prenom like CONCAT('%', @prenom, '%');"))
                {
                    commande.Parameters.AddWithValue("@nom", nom);
                    commande.Parameters.AddWithValue("@prenom", prenom);
                    result = Bdd.select(commande);
                }

                foreach(DataRow dr in result.Rows)
                {
                    Client unClient = new Client();
                    unClient.Id = (int)dr["id"];
                    unClient.IdPersonne = (int)dr["id_personne"];
                    unClient.Nom = (string)dr["nom"];
                    unClient.Prenom = (string)dr["prenom"];
                    unClient.Rue = (string)dr["rue"];
                    unClient.NumRue = (string)dr["numRue"].ToString();
                    unClient.NumTelephone = (string)dr["numTelephone"].ToString();
                    unClient.Ville = (string)dr["ville"];
                    unClient.Email = (string)dr["email"];
                    Globales.ClientsRecherche.Add(unClient.Id, unClient);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reussite = false;
            }

            return reussite;
        }
    }
}
