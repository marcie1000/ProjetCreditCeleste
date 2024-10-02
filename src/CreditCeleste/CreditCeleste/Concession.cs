using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Concession
    {
        private string monNomConcession;
        private string monAdresseConcession;

        // Collection de vendeurs
        private List<Vendeur> lesVendeurs = new List<Vendeur>();

        public Concession()
        {

        }

        public Concession(string nomConcession, string adresseConcession)
        {
            monNomConcession = nomConcession;
            monAdresseConcession = adresseConcession;
        }

        public List<Vendeur> getLesVendeurs()
        {
            return lesVendeurs;
        }

        public void ajoutVendeur(Vendeur oVendeur)
        {
            lesVendeurs.Add(oVendeur);
        }
    }
}
