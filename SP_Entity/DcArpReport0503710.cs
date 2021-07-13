using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503710
    {
        public DcArpReport0503710()
        {
            FsT10503710List = new HashSet<FsT10503710List>();
            FsT205037102020List = new HashSet<FsT205037102020List>();
            FsT20503710List = new HashSet<FsT20503710List>();
            FsT2190503710List = new HashSet<FsT2190503710List>();
            FsT30503710List = new HashSet<FsT30503710List>();
            FsT40503710List = new HashSet<FsT40503710List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string CentraccInstitutionCode { get; set; }
        public string CentraccName2 { get; set; }
        public string CentraccOgrnOgrnip { get; set; }
        public string CentraccInn { get; set; }
        public string CentraccKpp { get; set; }
        public string CentraccCaLeader { get; set; }
        public string CentraccCaExecutor { get; set; }
        public string CentraccCaLeader1 { get; set; }
        public string CentraccCaExecutor1 { get; set; }
        public string CentraccCaExecutorMail { get; set; }
        public string CentraccLocation { get; set; }
        public string CentraccAllPrint { get; set; }
        public string Tobalanceinform { get; set; }
        public string Tobalanceform { get; set; }
        public string EntNameseparatedivision { get; set; }
        public string EntCodeseparatedivision { get; set; }
        public string EntNamefounder { get; set; }
        public string EntCodefounder { get; set; }
        public string EntNamebodyactfounder { get; set; }
        public string EntCodebodyactfounder { get; set; }
        public string EntOkpobodyactfounder { get; set; }
        public bool? EntSubDiv { get; set; }
        public string SingLeader { get; set; }
        public string SingChiefAcc { get; set; }
        public string SingLeaderOfFes { get; set; }
        public string SingPostLeader { get; set; }
        public string SingPostChiefAcc { get; set; }
        public string SingPostLeaderOf { get; set; }
        public string SingExecutor { get; set; }
        public string SingPostExecutor { get; set; }
        public string SingPhone { get; set; }
        public string HrSingLeader { get; set; }
        public string HrSingChiefAcc { get; set; }
        public string HrSingLeaderOfFes { get; set; }
        public string HrSingPostLeader { get; set; }
        public string HrSingPostChiefAcc { get; set; }
        public string HrSingPostLeaderOf { get; set; }
        public string HrSingExecutor { get; set; }
        public string HrSingPostExecutor { get; set; }
        public string HrSingPhone { get; set; }
        public decimal? TotalC4R0219 { get; set; }
        public decimal? TotalC5R0219 { get; set; }
        public decimal? Ic4R022020 { get; set; }
        public decimal? Ic5R022020 { get; set; }
        public decimal? Ic6R022020 { get; set; }
        public decimal? Ic7R022020 { get; set; }
        public decimal? C2R01100 { get; set; }
        public decimal? C3R01100 { get; set; }
        public decimal? C4R01100 { get; set; }
        public decimal? C5R01100 { get; set; }
        public decimal? C6R01100 { get; set; }
        public decimal? C7R01100 { get; set; }
        public decimal? C8R01100 { get; set; }
        public decimal? C9R01100 { get; set; }
        public decimal? C10R01100 { get; set; }
        public decimal? C11R01100 { get; set; }
        public decimal? C12R01100 { get; set; }
        public decimal? C13R01100 { get; set; }

        public virtual ICollection<FsT10503710List> FsT10503710List { get; set; }
        public virtual ICollection<FsT205037102020List> FsT205037102020List { get; set; }
        public virtual ICollection<FsT20503710List> FsT20503710List { get; set; }
        public virtual ICollection<FsT2190503710List> FsT2190503710List { get; set; }
        public virtual ICollection<FsT30503710List> FsT30503710List { get; set; }
        public virtual ICollection<FsT40503710List> FsT40503710List { get; set; }
    }
}
