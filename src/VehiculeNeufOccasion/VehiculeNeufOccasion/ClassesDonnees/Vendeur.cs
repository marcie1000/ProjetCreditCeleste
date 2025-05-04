using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class Vendeur
    {
        public int Id { get; set; }

        public string Prenom { get; set; }

        public string Nom { get; set; }

        public string Email { get; set; }

        public string LocRue { get; set; }

        public string Rue { get; set; }

        public string CodePostal { get; set; }

        public string Ville { get; set; }

        public string Tel { get; set; }

        public int IdUtilisateur { get; set; }

        public virtual ICollection<Achat> Achats { get; set; } = new List<Achat>();

        public virtual Utilisateur IdUtilisateurNavigation { get; set; }
    }

}