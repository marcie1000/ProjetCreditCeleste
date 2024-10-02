using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Vendeur
    {
        private string monCcivVendeur; // Mme, Mlle, M.
        private string monNomVendeur;
        private string monPrenomVendeur;

        public Vendeur()
        {

        }

        public Vendeur(string cciv, string nom, string prenom)
        {
            monCcivVendeur = cciv;
            monNomVendeur = nom;
            monPrenomVendeur = prenom;
        }

        public void setCciv(string cciv)
        {
            monCcivVendeur = cciv;
        }

        public void setNom(string nom)
        {
            monNomVendeur = nom;
        }

        public void setPrenom(string prenom)
        {
            monPrenomVendeur = prenom;
        }

        public string getCciv()
        {
            return monCcivVendeur;
        }

        public string getNom()
        {
            return monNomVendeur;
        }

        public string getPrenom()
        {
            return monPrenomVendeur;
        }

        public string getInfoVendeur()
        {
            return monCcivVendeur + " " + monNomVendeur + " " + monPrenomVendeur;
        }
    }
}
