using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    static class Globales   // pas la peine de faire un new, classe statique
    {
        // public string nomUtilisateur = "Baudouin"; // un seul ; attribut de l'objet
        public static string nomUtilisateur = "Baudouin";   // un seul ; attribut de classe
        public static string maRegion = "Alsace";
        public static frmIntroduction fenIntroduction;
        public static frmAccueil fenAccueil;
        public static frmVoiture fenVoiture;
        public static Concession uneConcession;
        public static Client unClient;
        public static Vendeur monVendeur;
        public static Voiture monNouveauVehicule;
        public static Voiture monAncienVehicule;
        public static bool quitter = false;
    }
}
