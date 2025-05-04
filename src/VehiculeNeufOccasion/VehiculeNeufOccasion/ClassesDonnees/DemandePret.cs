using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class DemandePret
    {
        public int Id { get; set; }

        public decimal MontantTotal { get; set; }

        public bool Valide { get; set; }

        public bool AttenteValidation { get; set; }

        public DateTime DateOuverture { get; set; }

        public int NombreMensualites { get; set; }

        public decimal PrixMensualite { get; set; }

        public double Taux { get; set; }

        public decimal PremierApport { get; set; }

        public int IdAgenceCreditCeleste { get; set; }

        public int IdVente { get; set; }

        public virtual AgenceCreditCeleste IdAgenceCreditCelesteNavigation { get; set; }

        public virtual Vente IdVenteNavigation { get; set; }
    }

}

