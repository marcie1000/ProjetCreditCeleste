using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    static class Bdd
    {
        //private const string strConnexion = "Data Source=" + Globales.adresseSqlServer + "; User Id=cnxEleveSio; password=ArtemisL25!; Initial Catalog=Concession";
        private const string strConnexion = "Server=localhost\\SQLEXPRESS;Database=Concession;Integrated Security=true;TrustServerCertificate=true;";
        //private SqlConnection oConnexion;
        //private SqlDataAdapter oAdapteur;

        public static DataTable select(SqlCommand commande)
        {
            DataSet result = new DataSet();
            try
            {
                using (SqlConnection oConnexion = new SqlConnection(strConnexion))
                {
                    oConnexion.Open();
                    commande.Connection = oConnexion;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = commande;
                    adapter.Fill(result);
                    return result.Tables[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static int insert(SqlCommand commande)
        {
            DataSet result = new DataSet();
            try
            {
                using (SqlConnection oConnexion = new SqlConnection(strConnexion))
                {
                    oConnexion.Open();
                    commande.Connection = oConnexion;
                    return commande.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
