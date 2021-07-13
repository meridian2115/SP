using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2BDiagList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2OnkSlListid { get; set; }
        public DateTime? DiagDate { get; set; }
        public string DiagTip { get; set; }
        public string DiagCode { get; set; }
        public string DiagRslt { get; set; }
        public bool? RecRslt { get; set; }

        public virtual FsD2OnkSlList FsD2OnkSlList { get; set; }
    }
}
