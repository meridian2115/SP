using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503372
    {
        public DcArpReport0503372()
        {
            FsT10503372List = new HashSet<FsT10503372List>();
            FsT20503372List = new HashSet<FsT20503372List>();
            FsT30503372List = new HashSet<FsT30503372List>();
            FsT40503372List = new HashSet<FsT40503372List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Telephone { get; set; }
        public decimal? C2R01 { get; set; }
        public decimal? C3R01 { get; set; }
        public decimal? C2R02 { get; set; }
        public decimal? C3R02 { get; set; }
        public decimal? C5R03 { get; set; }
        public decimal? C6R03 { get; set; }
        public decimal? C3R04 { get; set; }
        public decimal? C4R04 { get; set; }

        public virtual ICollection<FsT10503372List> FsT10503372List { get; set; }
        public virtual ICollection<FsT20503372List> FsT20503372List { get; set; }
        public virtual ICollection<FsT30503372List> FsT30503372List { get; set; }
        public virtual ICollection<FsT40503372List> FsT40503372List { get; set; }
    }
}
