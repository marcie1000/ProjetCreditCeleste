using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class LesLocation
    {
        public int Id { get; set; }

        public DateTime DebutLoc { get; set; }

        public int ForfaitMensualite { get; set; }

        public DateTime FinLoc { get; set; }

        public int KilometrageDebut { get; set; }

        public int KilometrageFin { get; set; }

        public decimal PrixRevientKm { get; set; }

        public int IdClient { get; set; }

        public int IdVehicule { get; set; }

        public int IdGarage { get; set; }

        public virtual Client IdClientNavigation { get; set; }

        public virtual Garage IdGarageNavigation { get; set; }

        public virtual Vehicule IdVehiculeNavigation { get; set; }
    }

}