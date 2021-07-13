using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507052
    {
        public DcArpReport0507052()
        {
            FsT1052List = new HashSet<FsT1052List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public decimal? C7R1 { get; set; }
        public decimal? C8R1 { get; set; }
        public decimal? C9R1 { get; set; }
        public decimal? C10R1 { get; set; }
        public decimal? C11R1 { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsT1052List> FsT1052List { get; set; }
    }
}
