using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4OnkUslList
    {
        public FsD4OnkUslList()
        {
            FsD4LekPrList = new HashSet<FsD4LekPrList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4OnkSlListid { get; set; }
        public string UslTip { get; set; }
        public string HirTip { get; set; }
        public string LekTipL { get; set; }
        public string LekTipV { get; set; }
        public string Pptr { get; set; }
        public string LuchTip { get; set; }

        public virtual FsD4OnkSlList FsD4OnkSlList { get; set; }
        public virtual ICollection<FsD4LekPrList> FsD4LekPrList { get; set; }
    }
}
