using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Vente
    {
        public int Id { get; set; }

        public DateTime DateV { get; set; }

        public decimal Montant { get; set; }

        public bool Validee { get; set; }

        public int IdGarage { get; set; }

        public int IdClient { get; set; }

        public int IdVehicule { get; set; }

        public virtual ICollection<DemandePret> DemandePrets { get; set; } = new List<DemandePret>();

        public virtual Client IdClientNavigation { get; set; }

        public virtual Garage IdGarageNavigation { get; set; }

        public virtual Vehicule IdVehiculeNavigation { get; set; }
    }

}