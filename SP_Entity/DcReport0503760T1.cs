using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503760T1
    {
        public DcReport0503760T1()
        {
            FsS1T10503760List = new HashSet<FsS1T10503760List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public string HrCodereportform1 { get; set; }
        public string HrOkpo1 { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Ord { get; set; }
        public string Surrogat { get; set; }
        public bool? Subdiv { get; set; }

        public virtual ICollection<FsS1T10503760List> FsS1T10503760List { get; set; }
    }
}
