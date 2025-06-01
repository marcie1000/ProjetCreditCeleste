using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VehiculeNeufOccasion
{
    static class Globales
    {
        public static frmAccueil fenAccueil;
        public static Panel panelConteneurAcceuil;
        // chaîne de fenêtres actuellement dans le conteneur de fenAccueil
        // la liste permet de faire "Retour"
        public static ClSuiteDeFenetres suiteFenetres = new ClSuiteDeFenetres();
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
        public static Dictionary<int, Client> ClientsRecherche = new Dictionary<int, Client>();
        public static Client clientSelectionne;
        public static Client clientEdition; // pour la fenêtre de création / édition de client
        public static bool clientEditionValide = false;
        public static Vehicule vehiculeSelectionneVente;
        public static Vehicule vehiculeSelectionneLocation;
        public static decimal prixTotalAFinancer;
        public static Utilisateur UtilisateurConnecte = null;
        public static Client ClientTemporaire = null;
    }
}
