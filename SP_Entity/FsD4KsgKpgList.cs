using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4KsgKpgList
    {
        public FsD4KsgKpgList()
        {
            FsD4SlKoefList = new HashSet<FsD4SlKoefList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4SlListid { get; set; }
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

        public virtual FsD4SlList FsD4SlList { get; set; }
        public virtual ICollection<FsD4SlKoefList> FsD4SlKoefList { get; set; }
    }
}
