using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Garage
    {
        public int Id { get; set; }

        public string RaisonSociale { get; set; }

        public string LocRue { get; set; }

        public string NomRue { get; set; }

        public string CodePostal { get; set; }

        public string Ville { get; set; }

        public string Telephone { get; set; }

        public int IdRegion { get; set; }

        public int IdPersonne { get; set; }

        public virtual ICollection<Achat> Achats { get; set; } = new List<Achat>();

        public virtual Personne IdPersonneNavigation { get; set; }

        public virtual Region IdRegionNavigation { get; set; }

        public virtual ICollection<LesLocation> LesLocations { get; set; } = new List<LesLocation>();

        public virtual ICollection<Vente> Ventes { get; set; } = new List<Vente>();
    }

}

