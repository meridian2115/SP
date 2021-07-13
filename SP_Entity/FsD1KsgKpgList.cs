using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD1KsgKpgList
    {
        public FsD1KsgKpgList()
        {
            FsD1SlKoefList = new HashSet<FsD1SlKoefList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD1SlListid { get; set; }
        public string NKsg { get; set; }
        public string VerKsg { get; set; }
        public bool? KsgPg { get; set; }
        public string NKpg { get; set; }
        public decimal? KoefZ { get; set; }
        public decimal? KoefUp { get; set; }
        public decimal? Bztsz { get; set; }
        public decimal? KoefD { get; set; }
        public decimal? KoefU { get; set; }
        public string Crit { get; set; }
        public bool? SlK { get; set; }
        public decimal? ItSl { get; set; }

        public virtual FsD1SlList FsD1SlList { get; set; }
        public virtual ICollection<FsD1SlKoefList> FsD1SlKoefList { get; set; }
    }
}
