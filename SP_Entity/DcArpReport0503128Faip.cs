using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503128Faip
    {
        public DcArpReport0503128Faip()
        {
            FsR1T1128fList = new HashSet<FsR1T1128fList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? R1C7R1 { get; set; }
        public decimal? R1C8R1 { get; set; }
        public decimal? R1C81R1 { get; set; }
        public decimal? R1C82R1 { get; set; }
        public string R1C9R1 { get; set; }
        public string R1Table1 { get; set; }
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
        public string Developer { get; set; }

        public virtual ICollection<FsR1T1128fList> FsR1T1128fList { get; set; }
    }
}
