using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2OnkSlList
    {
        public FsD2OnkSlList()
        {
            FsD2BDiagList = new HashSet<FsD2BDiagList>();
            FsD2BProtList = new HashSet<FsD2BProtList>();
            FsD2OnkUslList = new HashSet<FsD2OnkUslList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2SlListid { get; set; }
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

        public virtual FsD2SlList FsD2SlList { get; set; }
        public virtual ICollection<FsD2BDiagList> FsD2BDiagList { get; set; }
        public virtual ICollection<FsD2BProtList> FsD2BProtList { get; set; }
        public virtual ICollection<FsD2OnkUslList> FsD2OnkUslList { get; set; }
    }
}
