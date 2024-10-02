using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CreditCeleste
{
    class Bdd
    {
        private const string strConnexion = "Data Source=10.129.253.209; User Id=connEleveSio; password=mdpEleveSio; Initial Catalog=CreditCeleste";
        private string strRequeteSelect = "SELECT nomVendeur, prenomVendeur, CCivVdr FROM Vendeur;";
        private SqlConnection oConnexion;
        private SqlDataAdapter oAdapteur;
        private DataSet oDSvdr;

        public Bdd()
        {
            oConnexion = new SqlConnection(strConnexion);
            oConnexion.Open();
            oAdapteur = new SqlDataAdapter(strRequeteSelect, oConnexion);
            oDSvdr = new DataSet();
            oAdapteur.Fill(oDSvdr, "Vdr");
        }

        public Vendeur selectVendeur(int index)
        {
            Vendeur v = new Vendeur();
            v.setCciv(oDSvdr.Tables["Vdr"].Rows[index]["CCivVdr"].ToString());
            v.setNom(oDSvdr.Tables["Vdr"].Rows[index]["nomVendeur"].ToString());
            v.setPrenom(oDSvdr.Tables["Vdr"].Rows[index]["prenomVendeur"].ToString());
            return v;
        }

        public int getNbVendeurs()
        {
            string sql = "SELECT COUNT(VENDEUR.*) FROM VENDEUR;";
            SqlCommand oCommand = new SqlCommand(sql, oConnexion);
            SqlDataReader oReader = oCommand.ExecuteReader();
            try
            {
                if (oReader.Read())
                    return Convert.ToInt32(oReader.GetValue(0));
                else
                    return 0;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur de connexion à la base de données.", e);
            }
        }

        public List<Vendeur> getAllVendeurs()
        {
            List<Vendeur> listeV = new List<Vendeur>();
            try
            {
                int nbVendeurs = getNbVendeurs();
                for(int i = 0; i < nbVendeurs; i++)
                {
                    listeV.Add(selectVendeur(i));
                }
                return listeV;
            }
            catch (Exception e)
            {
                throw new Exception("Erreur de connexion à la base de données.", e);
            }
        }

        public void insertVendeur(Vendeur v)
        {
            string sql = "insert into VENDEUR(nomVendeur, prenomVendeur) VALUES (";
            sql += "'" + v.getNom() + "', '" + v.getPrenom() + "');";
            SqlCommand cmd = new SqlCommand(sql, oConnexion);
            cmd.ExecuteNonQuery();
        }
    }
}
