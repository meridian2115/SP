using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507060
    {
        public DcArpReport0507060()
        {
            FsChangeremainsList = new HashSet<FsChangeremainsList>();
            FsLeavings7060List = new HashSet<FsLeavings7060List>();
            FsReceipts7060List = new HashSet<FsReceipts7060List>();
            FsT40507060List = new HashSet<FsT40507060List>();
            FsT50507060820List = new HashSet<FsT50507060820List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public decimal? Test { get; set; }
        public decimal? C5R800 { get; set; }
        public string C4R810 { get; set; }
        public decimal? C5R810 { get; set; }
        public string C4R820 { get; set; }
        public decimal? C5R820 { get; set; }

        public virtual ICollection<FsChangeremainsList> FsChangeremainsList { get; set; }
        public virtual ICollection<FsLeavings7060List> FsLeavings7060List { get; set; }
        public virtual ICollection<FsReceipts7060List> FsReceipts7060List { get; set; }
        public virtual ICollection<FsT40507060List> FsT40507060List { get; set; }
        public virtual ICollection<FsT50507060820List> FsT50507060820List { get; set; }
    }
}
