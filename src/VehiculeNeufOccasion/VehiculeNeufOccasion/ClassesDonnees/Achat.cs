using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Achat
    {
        public int Id { get; set; }

        public DateTime DateA { get; set; }

        public decimal Montant { get; set; }

        public int IdVendeur { get; set; }

        public int IdVehicule { get; set; }

        public int IdGarage { get; set; }

        public int IdClient { get; set; }

        public virtual Client IdClientNavigation { get; set; }

        public virtual Garage IdGarageNavigation { get; set; }

        public virtual Vehicule IdVehiculeNavigation { get; set; }

        public virtual Vendeur IdVendeurNavigation { get; set; }
    }
}