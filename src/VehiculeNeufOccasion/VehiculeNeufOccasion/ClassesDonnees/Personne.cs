using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Personne
    {
        public int Id { get; set; }

        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

        public virtual ICollection<Garage> Garages { get; set; } = new List<Garage>();

        public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
    }
}
