using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeNeufOccasion
{
    public class Voiture
    {
        private string marque;
        private string modele;
        private int annee;
        private int kilometrage;
        private string carburant;
        private int puissance;

        public Voiture() { }

        public Voiture(string ma, string mo)
        {
            marque = ma;
            modele = mo;
        }
        public Voiture(int km, string carb, int power)
        {
            kilometrage = km;
            carburant = carb;
            puissance = power;
        }
        public Voiture(string ma, string mo, int an, int km, string carb)
        {
            marque = ma;
            modele = mo;
            annee = an;
            kilometrage = km;
            carburant = carb;
        }
        public Voiture(string ma, string mo, int an, int km, string carb, int power)
        {
            marque = ma;
            modele = mo;
            annee = an;
            kilometrage = km;
            carburant = carb;
            puissance = power;
        }

        public void setMarque(string m)
        {
            this.marque = m;
        }
        public string getMarque()
        {
            return (this.marque);
        }


        public void setModele(string m)
        {
            this.modele = m;
        }
        public string getModele()
        {
            return (this.modele);
        }


        public void setAnnee(int a)
        {
            this.annee = a;
        }
        public int getAnnee()
        {
            return (this.annee);
        }


        public void setKm(int k)
        {
            this.kilometrage = k;
        }
        public int getKm()
        {
            return (this.kilometrage);
        }


        public void setCarburant(string c)
        {
            this.carburant = c;
        }
        public string getCarburant()
        {
            return (this.carburant);
        }


        public void setPuissance(int p)
        {
            this.puissance = p;
        }
        public int getPuissance()
        {
            return (this.puissance);
        }

    }
}
