using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpreport0503725
    {
        public HArpreport0503725()
        {
            HfsAccNumberList = new HashSet<HfsAccNumberList>();
            HfsMTransList = new HashSet<HfsMTransList>();
            HfsNmTransList = new HashSet<HfsNmTransList>();
            HfsTab0503725List = new HashSet<HfsTab0503725List>();
        }

        public decimal Id { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamehomeorg { get; set; }
        public string HrCodehomeorg { get; set; }
        public string HrReportBaseErOkpo1 { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public string NameKvfo { get; set; }
        public string CodeKvfo { get; set; }
        public string Accountcode { get; set; }
        public string AccCode { get; set; }
        public string Account { get; set; }
        public string Kosgu { get; set; }
        public decimal? ConsLnTtlC4R111 { get; set; }
        public decimal? ConsLnTtlC5R111 { get; set; }
        public string CentraccCode { get; set; }
        public string CentraccName { get; set; }
        public string CentraccOgrn { get; set; }
        public string CentraccInn { get; set; }
        public string CentraccKpp { get; set; }
        public string CaLeader { get; set; }
        public string CaExecutor { get; set; }
        public string CaLeader1 { get; set; }
        public string CaExecutor1 { get; set; }
        public string CaExecutorMail { get; set; }

        public virtual ICollection<HfsAccNumberList> HfsAccNumberList { get; set; }
        public virtual ICollection<HfsMTransList> HfsMTransList { get; set; }
        public virtual ICollection<HfsNmTransList> HfsNmTransList { get; set; }
        public virtual ICollection<HfsTab0503725List> HfsTab0503725List { get; set; }
    }
}
