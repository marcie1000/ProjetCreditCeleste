using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace VehiculeNeufOccasion
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // test connexion base de données
            try
            {
                Bdd maBdd = new Bdd();
                DataTable result = maBdd.select("SELECT * FROM VEHICULE;");
                string res = "";
                foreach (DataRow dr in result.Rows)
                {
                    foreach (DataColumn key in dr.Table.Columns)
                    {
                        res = res + key.ColumnName + " : " + dr[key] + "; ";
                    }
                    res = res + "\n";
                }
                MessageBox.Show(res);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            Application.Run(new frmAccueil());
        }
    }
}
