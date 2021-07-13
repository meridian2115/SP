using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcPrPrt0503317Np
    {
        public DcPrPrt0503317Np()
        {
            FsExc317NpList = new HashSet<FsExc317NpList>();
            FsRepVnk317NpList = new HashSet<FsRepVnk317NpList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string TitlePartOrd { get; set; }
        public DateTime? TitlePartPrintDate { get; set; }
        public string TitlePartUnsealed { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public DateTime? Logid { get; set; }
        public string PrCodereportform { get; set; }

        public virtual ICollection<FsExc317NpList> FsExc317NpList { get; set; }
        public virtual ICollection<FsRepVnk317NpList> FsRepVnk317NpList { get; set; }
    }
}
