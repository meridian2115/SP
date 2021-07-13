using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4OnkSlList
    {
        public FsD4OnkSlList()
        {
            FsD4BDiagList = new HashSet<FsD4BDiagList>();
            FsD4BProtList = new HashSet<FsD4BProtList>();
            FsD4OnkUslList = new HashSet<FsD4OnkUslList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4SlListid { get; set; }
        public string Ds1T { get; set; }
        public string Stad { get; set; }
        public decimal? OnkT { get; set; }
        public decimal? OnkN { get; set; }
        public decimal? OnkM { get; set; }
        public bool? Mtstz { get; set; }
        public decimal? Sod { get; set; }
        public decimal? KFr { get; set; }
        public decimal? Wei { get; set; }
        public decimal? Hei { get; set; }
        public decimal? Bsa { get; set; }

        public virtual FsD4SlList FsD4SlList { get; set; }
        public virtual ICollection<FsD4BDiagList> FsD4BDiagList { get; set; }
        public virtual ICollection<FsD4BProtList> FsD4BProtList { get; set; }
        public virtual ICollection<FsD4OnkUslList> FsD4OnkUslList { get; set; }
    }
}
