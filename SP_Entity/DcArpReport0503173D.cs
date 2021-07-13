using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503173D
    {
        public DcArpReport0503173D()
        {
            FsAsTab173ADList = new HashSet<FsAsTab173ADList>();
            FsLiTab173LDList = new HashSet<FsLiTab173LDList>();
            FsRcT173aItogDList = new HashSet<FsRcT173aItogDList>();
            FsRcT173bItogDList = new HashSet<FsRcT173bItogDList>();
            FsRcTab173aDList = new HashSet<FsRcTab173aDList>();
            FsRcTab173bDList = new HashSet<FsRcTab173bDList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string NameKvfo { get; set; }
        public string CodeKvfo { get; set; }
        public string Ord { get; set; }
        public decimal? RcC2R2 { get; set; }
        public decimal? RcC2R3 { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string CaExecutorTel { get; set; }
        public string Namtip { get; set; }
        public string Subotch { get; set; }
        public string CaExecutor { get; set; }
        public string PostCaExecutor { get; set; }
        public DateTime? ReportDatePrev { get; set; }
        public decimal? Test { get; set; }

        public virtual ICollection<FsAsTab173ADList> FsAsTab173ADList { get; set; }
        public virtual ICollection<FsLiTab173LDList> FsLiTab173LDList { get; set; }
        public virtual ICollection<FsRcT173aItogDList> FsRcT173aItogDList { get; set; }
        public virtual ICollection<FsRcT173bItogDList> FsRcT173bItogDList { get; set; }
        public virtual ICollection<FsRcTab173aDList> FsRcTab173aDList { get; set; }
        public virtual ICollection<FsRcTab173bDList> FsRcTab173bDList { get; set; }
    }
}
