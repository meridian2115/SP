using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2OnkUslList
    {
        public FsD2OnkUslList()
        {
            FsD2LekPrList = new HashSet<FsD2LekPrList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2OnkSlListid { get; set; }
        public string UslTip { get; set; }
        public string HirTip { get; set; }
        public string LekTipL { get; set; }
        public string LekTipV { get; set; }
        public string LuchTip { get; set; }
        public bool? Pptr { get; set; }

        public virtual FsD2OnkSlList FsD2OnkSlList { get; set; }
        public virtual ICollection<FsD2LekPrList> FsD2LekPrList { get; set; }
    }
}
