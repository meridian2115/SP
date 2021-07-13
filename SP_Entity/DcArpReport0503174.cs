using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503174
    {
        public DcArpReport0503174()
        {
            FsTab1T1List = new HashSet<FsTab1T1List>();
            FsTab1T2List = new HashSet<FsTab1T2List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Tab1C4R1 { get; set; }
        public decimal? Tab1C6R1 { get; set; }
        public decimal? Tab1C7R1 { get; set; }
        public decimal? Tab1C8R1 { get; set; }
        public decimal? Tab1C4R2 { get; set; }
        public decimal? Tab1C6R2 { get; set; }
        public decimal? Tab1C7R2 { get; set; }
        public decimal? Tab1C8R2 { get; set; }
        public decimal? Tab1C4R0 { get; set; }
        public decimal? Tab1C6R0 { get; set; }
        public decimal? Tab1C7R0 { get; set; }
        public decimal? Tab1C8R0 { get; set; }
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
        public string ExecuterTel { get; set; }

        public virtual ICollection<FsTab1T1List> FsTab1T1List { get; set; }
        public virtual ICollection<FsTab1T2List> FsTab1T2List { get; set; }
    }
}
