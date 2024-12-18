using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VehiculeNeufOccasion
{
    class Bdd
    {
        private const string strConnexion = "Data Source=" + Globales.adresseSqlServer + "; User Id=cnxEleveSio; password=Artemis24; Initial Catalog=Concession";
        //private SqlConnection oConnexion;
        //private SqlDataAdapter oAdapteur;
        public Bdd()
        {

        }

        public DataTable select(string commande)
        {
            DataSet result = new DataSet();
            try
            {
                using (SqlConnection oConnexion = new SqlConnection(strConnexion))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(commande, oConnexion);
                    adapter.Fill(result);
                    return result.Tables[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
