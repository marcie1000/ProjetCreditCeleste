using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehiculeNeufOccasion
{
    static class Globales
    {
        public static frmAccueil fenAccueil;
        public static frmAcheter fenAcheter;
        public static frmLouer fenLouer;
        public static frmVendre fenVendre;
        public static frmCreationUser fenCreerUser;
        //public const string adresseSqlServer = "192.168.43.130";
        public static int idGarage = 1;
        public static Garage LeGarage;
        public static Dictionary<int, Garage> Garages = new Dictionary<int, Garage>();
        public static Dictionary<int, Region> Regions = new Dictionary<int, Region>();
        public static Dictionary<int, Carburant> Carburants = new Dictionary<int, Carburant>();
        public static Dictionary<int, Etat> Etats = new Dictionary<int, Etat>();
        public static Dictionary<int, Marque> Marques = new Dictionary<int, Marque>();
        public static Dictionary<int, Vehicule> Vehicules = new Dictionary<int, Vehicule>();
        public static Dictionary<int, Modele> Modeles = new Dictionary<int, Modele>();
        public static Dictionary<int, Personne> Personnes = new Dictionary<int, Personne>();
    }
}
