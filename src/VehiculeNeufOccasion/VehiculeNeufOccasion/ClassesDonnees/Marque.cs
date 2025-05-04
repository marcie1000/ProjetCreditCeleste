using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Marque
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public virtual ICollection<Modele> Modeles { get; set; } = new List<Modele>();
    }
}
