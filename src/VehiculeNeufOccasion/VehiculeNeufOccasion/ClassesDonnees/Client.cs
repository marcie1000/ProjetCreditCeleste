using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Client
    {
        public int Id { get; set; }

        public string Prenom { get; set; }

        public string Nom { get; set; }

        public string NumRue { get; set; }

        public int Cp { get; set; }

        public string Ville { get; set; }

        public string NumTelephone { get; set; }

        public string Rue { get; set; }

        public string Email { get; set; }

        public int IdPersonne { get; set; }

        public virtual ICollection<Achat> Achats { get; set; } = new List<Achat>();

        public virtual Personne IdPersonneNavigation { get; set; }

        public virtual ICollection<LesLocation> LesLocations { get; set; } = new List<LesLocation>();

        public virtual ICollection<Vente> Ventes { get; set; } = new List<Vente>();
    }

}