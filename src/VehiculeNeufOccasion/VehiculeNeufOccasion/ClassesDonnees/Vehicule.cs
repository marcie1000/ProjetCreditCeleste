using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Vehicule
    {
        public int Id { get; set; }

        public int Annee { get; set; }

        public int Kilometrage { get; set; }

        public decimal Prix { get; set; }

        public int Puissance { get; set; }

        public string Couleur { get; set; }

        public int IdEtat { get; set; }

        public int IdCarburant { get; set; }

        public int IdModele { get; set; }

        public int IdPersonnePossession { get; set; }

        public virtual ICollection<Achat> Achats { get; set; } = new List<Achat>();

        public virtual Carburant IdCarburantNavigation { get; set; }

        public virtual Etat IdEtatNavigation { get; set; }

        public virtual Modele IdModeleNavigation { get; set; }

        public virtual Personne IdPersonnePossessionNavigation { get; set; }

        public virtual ICollection<LesLocation> LesLocations { get; set; } = new List<LesLocation>();

        public virtual ICollection<Vente> Ventes { get; set; } = new List<Vente>();
    }

}