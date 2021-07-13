using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabMonitoringTList
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
        public DateTime? ActDate { get; set; }
        public string TotalAmnt { get; set; }
        public string AmntSbmt { get; set; }
        public string AmntWork { get; set; }
        public string AmntCancel { get; set; }
        public string AmntEpmty { get; set; }
        public string AmntNocreate { get; set; }

        public virtual DcArpMonitoring Doc { get; set; }
    }
}
