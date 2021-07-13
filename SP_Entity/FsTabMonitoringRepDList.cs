using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabMonitoringRepDList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Num { get; set; }
        public string StateRep { get; set; }
        public string Okud { get; set; }
        public string Acc { get; set; }
        public string Ai { get; set; }
        public string NmRep { get; set; }
        public string Reptype { get; set; }
        public DateTime? SbmtDate { get; set; }
        public DateTime? ActDate { get; set; }

        public virtual DcArpMonitoring Doc { get; set; }
    }
}
