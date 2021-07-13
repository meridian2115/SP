using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503374
    {
        public DcArpReport0503374()
        {
            FsT10503374List = new HashSet<FsT10503374List>();
            FsT20503374List = new HashSet<FsT20503374List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public decimal? C3Ttl1 { get; set; }
        public decimal? C4Ttl1 { get; set; }
        public decimal? C6Ttl1 { get; set; }
        public decimal? C7Ttl1 { get; set; }
        public decimal? C8Ttl1 { get; set; }
        public decimal? C3Ttl2 { get; set; }
        public decimal? C4Ttl2 { get; set; }
        public decimal? C6Ttl2 { get; set; }
        public decimal? C7Ttl2 { get; set; }
        public decimal? C8Ttl2 { get; set; }
        public decimal? C4Ttl3 { get; set; }
        public decimal? C6Ttl3 { get; set; }
        public decimal? C7Ttl3 { get; set; }
        public decimal? C8Ttl3 { get; set; }
        public string ExecuterTel { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsT10503374List> FsT10503374List { get; set; }
        public virtual ICollection<FsT20503374List> FsT20503374List { get; set; }
    }
}
