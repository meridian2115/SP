using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4LekPrList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4OnkUslListid { get; set; }
        public string Regnum { get; set; }
        public string CodeSh { get; set; }
        public DateTime? DateInj { get; set; }

        public virtual FsD4OnkUslList FsD4OnkUslList { get; set; }
    }
}
