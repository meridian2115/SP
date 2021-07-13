using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503773D
    {
        public DcArpReport0503773D()
        {
            FsRcTab0503773adList = new HashSet<FsRcTab0503773adList>();
            FsRcTab0503773bdList = new HashSet<FsRcTab0503773bdList>();
            FsRcTab773aItogdList = new HashSet<FsRcTab773aItogdList>();
            FsRcTab773bItogdList = new HashSet<FsRcTab773bItogdList>();
            FsTab0503773D1List = new HashSet<FsTab0503773D1List>();
            FsTab0503773D2List = new HashSet<FsTab0503773D2List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrNameseparatedivision { get; set; }
        public string HrCodeseparatedivision { get; set; }
        public string HrNamefounder { get; set; }
        public string HrCodefounder { get; set; }
        public string HrNamebodyactingfounder { get; set; }
        public string HrCodebodyactingfounder { get; set; }
        public string HrNameKvfo { get; set; }
        public string HrCodeKvfo { get; set; }
        public string Ord { get; set; }
        public decimal? RcC2R2 { get; set; }
        public decimal? RcC2R3 { get; set; }
        public string CaCode { get; set; }
        public string CaName { get; set; }
        public string CaOgrn { get; set; }
        public string CaInn { get; set; }
        public string CaKpp { get; set; }
        public string CaCaLeader { get; set; }
        public string CaCaExecutor { get; set; }
        public string CaPostCaLeader { get; set; }
        public string CaPostCaExecutor { get; set; }
        public string CaCaExecutorMail { get; set; }
        public string SeLeader { get; set; }
        public string SeChiefAcc { get; set; }
        public string SeLeaderOfFes { get; set; }
        public string SePostLeader { get; set; }
        public string SePostChiefAcc { get; set; }
        public string SePostLeaderOf { get; set; }
        public string SeExecutor { get; set; }
        public string SePostExecutor { get; set; }
        public string SePhone { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string Address { get; set; }
        public bool? SubDiv { get; set; }
        public string Cd373d { get; set; }
        public string Cd373z { get; set; }
        public string Cd373i { get; set; }
        public string Cd373c { get; set; }
        public string Cd373m { get; set; }
        public string Cd373t { get; set; }
        public string CustomerCode { get; set; }

        public virtual ICollection<FsRcTab0503773adList> FsRcTab0503773adList { get; set; }
        public virtual ICollection<FsRcTab0503773bdList> FsRcTab0503773bdList { get; set; }
        public virtual ICollection<FsRcTab773aItogdList> FsRcTab773aItogdList { get; set; }
        public virtual ICollection<FsRcTab773bItogdList> FsRcTab773bItogdList { get; set; }
        public virtual ICollection<FsTab0503773D1List> FsTab0503773D1List { get; set; }
        public virtual ICollection<FsTab0503773D2List> FsTab0503773D2List { get; set; }
    }
}
