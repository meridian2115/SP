using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503771
    {
        public DcReport0503771()
        {
            FsInffininvinstList = new HashSet<FsInffininvinstList>();
            FsTotaaccodeList = new HashSet<FsTotaaccodeList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string Ord { get; set; }
        public decimal? C2R01010 { get; set; }
        public string Okpo1 { get; set; }
        public string Tobalanceinform { get; set; }

        public virtual ICollection<FsInffininvinstList> FsInffininvinstList { get; set; }
        public virtual ICollection<FsTotaaccodeList> FsTotaaccodeList { get; set; }
    }
}
