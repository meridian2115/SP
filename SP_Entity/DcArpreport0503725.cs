using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpreport0503725
    {
        public DcArpreport0503725()
        {
            FsAccNumberList = new HashSet<FsAccNumberList>();
            FsMTransList = new HashSet<FsMTransList>();
            FsNmTransList = new HashSet<FsNmTransList>();
            FsTab0503725List = new HashSet<FsTab0503725List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamehomeorg { get; set; }
        public string HrCodehomeorg { get; set; }
        public string HrReportBaseErOkpo1 { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public bool? HrSubDiv { get; set; }
        public string NameKvfo { get; set; }
        public string CodeKvfo { get; set; }
        public string Accountcode { get; set; }
        public string AccCode { get; set; }
        public string Account { get; set; }
        public string Kosgu { get; set; }
        public decimal? ConsLnTtlC4R111 { get; set; }
        public decimal? ConsLnTtlC5R111 { get; set; }
        public string PenLeader { get; set; }
        public string PenChiefAcc { get; set; }
        public string PenLeaderOfFes { get; set; }
        public string PenPostLeader { get; set; }
        public string PenPostChiefAcc { get; set; }
        public string PenPostLeaderOf { get; set; }
        public string PenExecutor { get; set; }
        public string PenPostExecutor { get; set; }
        public string PenPhone { get; set; }
        public string CentraccCode { get; set; }
        public string CentraccName { get; set; }
        public string CentraccOgrn { get; set; }
        public string CentraccInn { get; set; }
        public string CentraccKpp { get; set; }
        public string CentraccLocation { get; set; }
        public string CentraccAllPrint { get; set; }
        public string CaLeader { get; set; }
        public string CaExecutor { get; set; }
        public string CaLeader1 { get; set; }
        public string CaExecutor1 { get; set; }
        public string CaExecutorMail { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsAccNumberList> FsAccNumberList { get; set; }
        public virtual ICollection<FsMTransList> FsMTransList { get; set; }
        public virtual ICollection<FsNmTransList> FsNmTransList { get; set; }
        public virtual ICollection<FsTab0503725List> FsTab0503725List { get; set; }
    }
}
