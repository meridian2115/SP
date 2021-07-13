using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabMonitoringList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string CdAlt { get; set; }
        public string CdTofk { get; set; }
        public string TypeSub { get; set; }
        public string CdSub { get; set; }
        public string NmSub { get; set; }
        public decimal? Percent { get; set; }
        public decimal? Missing { get; set; }
        public DateTime? SbmtDate { get; set; }

        public virtual DcArpMonitoring Doc { get; set; }
    }
}
