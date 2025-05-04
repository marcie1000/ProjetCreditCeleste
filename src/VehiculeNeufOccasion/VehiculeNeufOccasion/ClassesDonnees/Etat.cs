using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Etat
    {
        public int Id { get; set; }

        public string Designation { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
    }

}

