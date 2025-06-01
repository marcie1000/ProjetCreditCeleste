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
