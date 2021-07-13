using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503110
    {
        public DcReport0503110()
        {
            FsT10503110List = new HashSet<FsT10503110List>();
            FsT20503110List = new HashSet<FsT20503110List>();
            FsT30503110List = new HashSet<FsT30503110List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C2R01200 { get; set; }
        public decimal? C3R01200 { get; set; }
        public decimal? C4R01200 { get; set; }
        public decimal? C5R01200 { get; set; }
        public decimal? C6R01200 { get; set; }
        public decimal? C7R01200 { get; set; }
        public decimal? C8R01200 { get; set; }
        public decimal? C9R01200 { get; set; }
        public decimal? C2R02200 { get; set; }
        public decimal? C3R02200 { get; set; }
        public decimal? C4R02200 { get; set; }
        public decimal? C5R02200 { get; set; }
        public decimal? C6R02200 { get; set; }
        public decimal? C7R02200 { get; set; }
        public decimal? C4R03200 { get; set; }
        public decimal? C5R03200 { get; set; }
        public string Ord { get; set; }
        public string HrSingLeader { get; set; }
        public string HrSingChiefAcc { get; set; }
        public string HrSingLeaderOfFes { get; set; }
        public string HrSingPostLeader { get; set; }
        public string HrSingPostChiefAcc { get; set; }
        public string HrSingPostLeaderOf { get; set; }
        public string HrSingExecutor { get; set; }
        public string HrSingPostExecutor { get; set; }
        public string HrSingPhone { get; set; }
        public string Tobalanceinform { get; set; }
        public string Tobalanceform { get; set; }
        public string Telephone { get; set; }
        public DateTime? Date01012018 { get; set; }

        public virtual ICollection<FsT10503110List> FsT10503110List { get; set; }
        public virtual ICollection<FsT20503110List> FsT20503110List { get; set; }
        public virtual ICollection<FsT30503110List> FsT30503110List { get; set; }
    }
}
