using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReportForm0503377
    {
        public DcArpReportForm0503377()
        {
            FsT10503377List = new HashSet<FsT10503377List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C3aR1 { get; set; }
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

        public virtual ICollection<FsT10503377List> FsT10503377List { get; set; }
    }
}
