using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503167
    {
        public DcReport0503167()
        {
            FsT0503167List = new HashSet<FsT0503167List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrSingLeader { get; set; }
        public string HrSingChiefAcc { get; set; }
        public string HrSingLeaderOfFes { get; set; }
        public string HrSingPostLeader { get; set; }
        public string HrSingPostChiefAcc { get; set; }
        public string HrSingPostLeaderOf { get; set; }
        public string HrSingExecutor { get; set; }
        public string HrSingPostExecutor { get; set; }
        public string HrSingPhone { get; set; }
        public string HrSubotch { get; set; }
        public string Surrogat { get; set; }
        public string Ord { get; set; }
        public string TelIsp { get; set; }

        public virtual ICollection<FsT0503167List> FsT0503167List { get; set; }
    }
}
