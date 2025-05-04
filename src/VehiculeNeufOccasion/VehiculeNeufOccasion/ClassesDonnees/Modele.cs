using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Modele
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int IdMarque { get; set; }

        public virtual Marque IdMarqueNavigation { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
    }
}
