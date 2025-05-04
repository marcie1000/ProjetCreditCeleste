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
    public static class LogiqueVente
    {
        /// <summary>
        /// Cherche le modèle d'un véhicule dans les modèles chargés dans les classes ou dans la base de données
        /// si elle n'est pas encore chargée. 
        /// </summary>
        /// <returns>true si tout a fonctionné.</returns>
        private static bool getLeModeleDuVehicule(Vehicule unVehicule)
        {
            bool reussite = true;

            if (Globales.Modeles.ContainsKey(unVehicule.IdModele))
            {
                unVehicule.IdModeleNavigation = Globales.Modeles[unVehicule.IdModele];
                //Globales.Modeles[v.IdModele].Vehicules.Add(v);
            }
            else
            {
                try
                {
                    using (SqlCommand commande = new SqlCommand("SELECT * FROM concession.MODELE WHERE id = @idModele;"))
                    {
                        commande.Parameters.AddWithValue("@idModele", unVehicule.IdModele);
                        DataTable result = Bdd.select(commande);
                        if (result.Rows.Count != 0)
                        {
                            Modele unModele = new Modele();
                            unModele.Id = (int)result.Rows[0]["id"];
                            unModele.IdMarque = (int)result.Rows[0]["id_marque"];
                            unModele.IdMarqueNavigation = Globales.Marques[unModele.IdMarque];
                            unModele.Nom = (string)result.Rows[0]["nom"];
                            //unModele.Vehicules.Add(v);
                            Globales.Modeles.Add(unModele.Id, unModele);
                            unVehicule.IdModeleNavigation = unModele;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reussite = false;
                }

            }
            return reussite;
        }


        /// <summary>
        /// Récupère les véhicules (et les données associées) appartenant au garage dans la base de données.
        /// </summary>
        /// <returns>true si tout a fonctionné.</returns>
        public static bool getLesVehiculesDuGarage()
        {
            bool reussite = true;

            Globales.Vehicules.Clear();

            using (SqlCommand commande = new SqlCommand("SELECT * FROM concession.VEHICULE WHERE id_personnePossession = @idGarage;"))
            {
                commande.Parameters.AddWithValue("@idGarage", Globales.idGarage);

                try
                {
                    DataTable result = Bdd.select(commande);
                    foreach (DataRow dr in result.Rows)
                    {
                        Vehicule leVehicule = new Vehicule();
                        leVehicule.Id = (int)dr["id"];
                        leVehicule.Annee = (int)dr["annee"];
                        leVehicule.Kilometrage = (int)dr["kilometrage"];
                        leVehicule.Prix = (decimal)dr["prix"];
                        leVehicule.Puissance = (int)dr["puissance"];
                        leVehicule.Couleur = (string)dr["couleur"];
                        leVehicule.IdEtat = (int)dr["id_etat"];
                        leVehicule.IdEtatNavigation = Globales.Etats[leVehicule.IdEtat];
                        leVehicule.IdCarburant = (int)dr["id_carburant"];
                        leVehicule.IdCarburantNavigation = Globales.Carburants[leVehicule.IdCarburant];
                        leVehicule.IdModele = (int)dr["id_modele"];
                        leVehicule.IdPersonnePossession = Globales.idGarage;
                        Globales.Vehicules.Add(leVehicule.Id, leVehicule);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reussite = false;
                }
            }

            // sélectionner les modèles de véhicules concernés
            foreach (Vehicule unVehicule in Globales.Vehicules.Values)
            {
                if(!getLeModeleDuVehicule(unVehicule))
                {
                    reussite = false;
                    throw new Exception("Erreur dans la récupération de la liste de véhicules !");
                }
            }
            return reussite;
        }
    }
}
