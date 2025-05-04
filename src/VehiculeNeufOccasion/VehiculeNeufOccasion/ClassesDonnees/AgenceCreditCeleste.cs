using System;
using System.Collections.Generic;

namespace VehiculeNeufOccasion
{
    public partial class AgenceCreditCeleste
    {
        public int Id { get; set; }

        public string RaisonSociale { get; set; }

        public string LocRue { get; set; }

        public string NomRue { get; set; }

        public string CodePostal { get; set; }

        public string Ville { get; set; }

        public int IdRegion { get; set; }

        public virtual ICollection<DemandePret> DemandePrets { get; set; } = new List<DemandePret>();

        public virtual Region IdRegionNavigation { get; set; }
    }

}