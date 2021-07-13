using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpperort0507024
    {
        public DcArpperort0507024()
        {
            FsInfoTableList = new HashSet<FsInfoTableList>();
            FsSvodSvedIspList = new HashSet<FsSvodSvedIspList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string TitlePartOrd { get; set; }
        public DateTime? TitlePartPrintDate { get; set; }
        public string TitlePartUnsealed { get; set; }
        public string TitlePartForm { get; set; }
        public decimal? ResSvodResNotFulf { get; set; }
        public decimal? ResSvodResAccAblig { get; set; }
        public decimal? ResSvodResAccepDec { get; set; }
        public decimal? ResSvodResExecOblig { get; set; }
        public decimal? ResSvodResReas { get; set; }
        public decimal? ResSvodResNotExec { get; set; }
        public string ResInfResOutsDoc { get; set; }
        public decimal? ResInfResQuant { get; set; }
        public decimal? ResInfResSum { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }

        public virtual ICollection<FsInfoTableList> FsInfoTableList { get; set; }
        public virtual ICollection<FsSvodSvedIspList> FsSvodSvedIspList { get; set; }
    }
}
