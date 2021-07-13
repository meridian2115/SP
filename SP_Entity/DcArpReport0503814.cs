using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503814
    {
        public DcArpReport0503814()
        {
            FsInfoTabr1814List = new HashSet<FsInfoTabr1814List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string TelIsp { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public decimal? InfoC6 { get; set; }
        public decimal? InfoC7 { get; set; }
        public decimal? InfoC8 { get; set; }
        public decimal? InfoC9 { get; set; }

        public virtual ICollection<FsInfoTabr1814List> FsInfoTabr1814List { get; set; }
    }
}
