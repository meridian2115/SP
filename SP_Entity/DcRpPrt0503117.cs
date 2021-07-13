using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRpPrt0503117
    {
        public DcRpPrt0503117()
        {
            FsRepVnk117List = new HashSet<FsRepVnk117List>();
            T01Vnk117 = new HashSet<T01Vnk117>();
            T02Vnk117 = new HashSet<T02Vnk117>();
            T03Vnk117 = new HashSet<T03Vnk117>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string TitlePartReportType { get; set; }
        public DateTime? TitlePartPrintDate { get; set; }
        public string TitlePartUnsealed { get; set; }
        public string TitlePartOrd { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public decimal? TIncT117p1g5 { get; set; }
        public decimal? TIncT151p1g4 { get; set; }
        public decimal? TIncTotalInc { get; set; }
        public decimal? TConsT117p2g5 { get; set; }
        public decimal? TConsT151pt2g4 { get; set; }
        public decimal? TConsTInc { get; set; }
        public decimal? TSBugT117p3g5 { get; set; }
        public decimal? TSBugT151p3g4 { get; set; }
        public decimal? TSBugTSBug { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsRepVnk117List> FsRepVnk117List { get; set; }
        public virtual ICollection<T01Vnk117> T01Vnk117 { get; set; }
        public virtual ICollection<T02Vnk117> T02Vnk117 { get; set; }
        public virtual ICollection<T03Vnk117> T03Vnk117 { get; set; }
    }
}
