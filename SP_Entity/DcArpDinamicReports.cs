using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpDinamicReports
    {
        public DcArpDinamicReports()
        {
            FsTabDinRepList = new HashSet<FsTabDinRepList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string ReportCd { get; set; }
        public string ReportNm { get; set; }
        public string Levelrecord { get; set; }
        public string TabNm { get; set; }
        public string TabSysnm { get; set; }
        public string PrntCd { get; set; }
        public string PrntNm { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Num { get; set; }

        public virtual ICollection<FsTabDinRepList> FsTabDinRepList { get; set; }
    }
}
