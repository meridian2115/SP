using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507068
    {
        public DcArpReport0507068()
        {
            FsTab0507068List = new HashSet<FsTab0507068List>();
            FsTab20507068List = new HashSet<FsTab20507068List>();
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
        public decimal? C3R1Ttl { get; set; }
        public decimal? C3R1T2 { get; set; }

        public virtual ICollection<FsTab0507068List> FsTab0507068List { get; set; }
        public virtual ICollection<FsTab20507068List> FsTab20507068List { get; set; }
    }
}
