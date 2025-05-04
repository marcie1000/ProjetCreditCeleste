using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Region
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public virtual ICollection<AgenceCreditCeleste> AgenceCreditCelestes { get; set; } = new List<AgenceCreditCeleste>();

        public virtual ICollection<Garage> Garages { get; set; } = new List<Garage>();
    }

}