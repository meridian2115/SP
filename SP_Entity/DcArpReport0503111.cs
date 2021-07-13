using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503111
    {
        public DcArpReport0503111()
        {
            FsT10503111List = new HashSet<FsT10503111List>();
            FsT20503111List = new HashSet<FsT20503111List>();
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
        public decimal? C10R01200 { get; set; }
        public decimal? C11R01200 { get; set; }
        public decimal? C12R01200 { get; set; }
        public decimal? C13R01200 { get; set; }
        public decimal? C14R01200 { get; set; }
        public decimal? C15R01200 { get; set; }
        public decimal? C16R01200 { get; set; }
        public decimal? C17R01200 { get; set; }
        public decimal? C18R01200 { get; set; }
        public decimal? C19R01200 { get; set; }
        public decimal? C2R02200 { get; set; }
        public decimal? C3R02200 { get; set; }
        public decimal? C4R02200 { get; set; }
        public decimal? C5R02200 { get; set; }
        public decimal? C6R02200 { get; set; }
        public decimal? C7R02200 { get; set; }
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
        public string HrBalance { get; set; }
        public string HrOkei { get; set; }
        public string Tlfn { get; set; }

        public virtual ICollection<FsT10503111List> FsT10503111List { get; set; }
        public virtual ICollection<FsT20503111List> FsT20503111List { get; set; }
    }
}
