using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2LekPrList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2OnkUslListid { get; set; }
        public string Regnum { get; set; }
        public string CodeSh { get; set; }
        public DateTime? DateInj { get; set; }

        public virtual FsD2OnkUslList FsD2OnkUslList { get; set; }
    }
}
