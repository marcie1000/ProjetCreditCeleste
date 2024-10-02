using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {
        //public enum ageV
        //{
        //    neuf,
        //    moins3ans,
        //    de3a5ans,
        //    plus5ans
        //};

        private string nomVehicule;
        private DateTime date1ereImmat;
        private string numeroImmat;
        private string numeroSerie;
        private double puissance;
        private string ageVehicule;

        public Voiture()
        {

        }

        public Voiture(string leNom, DateTime laDate1ereImmat, string leNumeroImmat, string leNumeroSerie, double laPuissance, string lAgeVehicule)
        {
            setLaVoiture(leNom, laDate1ereImmat, leNumeroImmat, leNumeroSerie, laPuissance, lAgeVehicule);
        }

        public void setLaVoiture(string leNom, DateTime laDate1ereImmat, string leNumeroImmat, string leNumeroSerie, double laPuissance, string lAgeVehicule)
        {
            nomVehicule = leNom;
            date1ereImmat = laDate1ereImmat;
            numeroImmat = leNumeroImmat;
            numeroSerie = leNumeroSerie;
            puissance = laPuissance;
            ageVehicule = lAgeVehicule;
        }

        public void setLeNom(string leNom)
        {
            nomVehicule = leNom;
        }

        public void setLage(string lAgeVehicule)
        {
            ageVehicule = lAgeVehicule;
        }

        public string getLeNom()
        {
            return nomVehicule;
        }

        public string getLage()
        {
            return ageVehicule;
        }
    }
}
