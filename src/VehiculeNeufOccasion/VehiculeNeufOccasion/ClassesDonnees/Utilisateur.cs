using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Utilisateur
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Mdp { get; set; }

        public int Sel { get; set; }

        public bool Admin { get; set; }

        public virtual ICollection<Vendeur> Vendeurs { get; set; } = new List<Vendeur>();
    }

}