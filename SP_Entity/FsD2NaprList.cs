using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2NaprList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2SlListid { get; set; }
        public DateTime? NaprDate { get; set; }
        public string NaprMo { get; set; }
        public string NaprV { get; set; }
        public string MetIssl { get; set; }
        public string NaprUsl { get; set; }

        public virtual FsD2SlList FsD2SlList { get; set; }
    }
}
