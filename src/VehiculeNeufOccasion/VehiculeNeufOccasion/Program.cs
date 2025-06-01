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
        /// Fonction pour initialiser les principales données.
        /// </summary>
        static bool initialisation()
        {
            // est-ce que la fonction a réussi (valeur de retour)
            bool reussite = true;

            // récupérer les régions
            try
            {
                DataTable result = Bdd.select(new SqlCommand("SELECT * FROM concession.REGION;"));
                foreach (DataRow dr in result.Rows)
                {
                    Region laRegion = new Region();
                    laRegion.Id = (int)dr["id"];
                    laRegion.Nom = (string)dr["nom"];
                    Globales.Regions.Add(laRegion.Id, laRegion);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            // récupérer les carburants
            try
            {
                DataTable result = Bdd.select(new SqlCommand("SELECT * FROM concession.CARBURANT;"));
                foreach (DataRow dr in result.Rows)
                {
                    Carburant leCarburant = new Carburant();
                    leCarburant.Id = (int)dr["id"];
                    leCarburant.Designation = (string)dr["designation"];
                    Globales.Carburants.Add(leCarburant.Id, leCarburant);
                    Globales.CarburantsParNom.Add(leCarburant.Designation, leCarburant);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            // récupérer les états
            try
            {
                DataTable result = Bdd.select(new SqlCommand("SELECT * FROM concession.ETAT;"));
                foreach (DataRow dr in result.Rows)
                {
                    Etat lEtat = new Etat();
                    lEtat.Id = (int)dr["id"];
                    lEtat.Designation = (string)dr["designation"];
                    Globales.Etats.Add(lEtat.Id, lEtat);
                    Globales.EtatsParNom.Add(lEtat.Designation, lEtat);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            // récupérer les marques
            try
            {
                DataTable result = Bdd.select(new SqlCommand("SELECT * FROM concession.MARQUE;"));
                foreach (DataRow dr in result.Rows)
                {
                    Marque laMarque = new Marque();
                    laMarque.Id = (int)dr["id"];
                    laMarque.Nom = (string)dr["nom"];
                    Globales.Marques.Add(laMarque.Id, laMarque);
                    Globales.MarquesParNom.Add(laMarque.Nom, laMarque);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            // récupérer les garages
            try
            {
                DataTable result = Bdd.select(new SqlCommand("SELECT * FROM concession.GARAGE;"));
                foreach (DataRow dr in result.Rows)
                {
                    Garage unGarage = new Garage();
                    unGarage.Id = (int)dr["id"];
                    unGarage.RaisonSociale = (string)dr["raisonSociale"];
                    unGarage.LocRue = (string)dr["locRue"];
                    unGarage.NomRue = (string)dr["nomRue"];
                    unGarage.CodePostal = (string)dr["codePostal"];
                    unGarage.Ville = (string)dr["ville"];
                    unGarage.Telephone = (string)dr["telephone"];
                    unGarage.IdRegion = (int)dr["id_region"];
                    if(Globales.Regions.ContainsKey(unGarage.IdRegion))
                        unGarage.IdRegionNavigation = Globales.Regions[unGarage.IdRegion];
                    unGarage.IdPersonne = (int)dr["id_personne"];
                    Globales.Garages.Add(unGarage.Id, unGarage);

                    if (unGarage.Id == Globales.idGarage)
                        Globales.LeGarage = unGarage;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            // sélection de la personne concernée par le garage
            try
            {
                using(SqlCommand commande = new SqlCommand("SELECT * FROM concession.PERSONNE;"))
                {
                    commande.Parameters.AddWithValue("@idPersonne", Globales.LeGarage.IdPersonne);
                    DataTable result = Bdd.select(commande);
                    foreach(DataRow dr in result.Rows)
                    {
                        Personne laPersonne = new Personne();
                        laPersonne.Id = (int)dr["id"];
                        Globales.Personnes.Add(laPersonne.Id, laPersonne);
                        Globales.LeGarage.IdPersonneNavigation = laPersonne;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            // récupérer les modèles
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM concession.MODELE;"))
                {
                    DataTable result = Bdd.select(command);
                    foreach (DataRow dr in result.Rows)
                    {
                        Modele leMod = new Modele();
                        leMod.Id = (int)dr["id"];
                        leMod.IdMarque = (int)dr["id_marque"];
                        leMod.IdMarqueNavigation = Globales.Marques[leMod.IdMarque];
                        leMod.Nom = (string)dr["nom"];
                        Globales.Modeles.Add(leMod.Id, leMod);
                        Globales.Marques[leMod.IdMarque].Modeles.Add(leMod);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                reussite = false;
            }

            return reussite;
        }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // récupérer les données de base de l'application
            if (initialisation())
                MessageBox.Show("La base de données fonctionne.");
            else
                MessageBox.Show("La base de données à rencontré un problème.");

            Globales.fenAccueil = new frmAccueil();
            Application.Run(Globales.fenAccueil);
        }
    }
}
