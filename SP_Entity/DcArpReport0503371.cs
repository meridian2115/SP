using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503371
    {
        public DcArpReport0503371()
        {
            FsT10503371List = new HashSet<FsT10503371List>();
            FsT20503371List = new HashSet<FsT20503371List>();
            FsT30503371List = new HashSet<FsT30503371List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Sum3 { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public string HrOrd { get; set; }
        public string TelIsp { get; set; }

        public virtual ICollection<FsT10503371List> FsT10503371List { get; set; }
        public virtual ICollection<FsT20503371List> FsT20503371List { get; set; }
        public virtual ICollection<FsT30503371List> FsT30503371List { get; set; }
    }
}
