using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsDbdOifbeDetailedList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsDbdOifbeSummaryListid { get; set; }
        public string St1 { get; set; }
        public string St2a { get; set; }
        public string St2b { get; set; }
        public string St2c { get; set; }
        public string St2d { get; set; }
        public string St2e { get; set; }
        public decimal? St3 { get; set; }
        public decimal? St4 { get; set; }
        public decimal? St5 { get; set; }
        public decimal? St6 { get; set; }
        public decimal? St7 { get; set; }

        public virtual FsDbdOifbeSummaryList FsDbdOifbeSummaryList { get; set; }
    }
}
