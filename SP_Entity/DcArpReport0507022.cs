using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507022
    {
        public DcArpReport0507022()
        {
            FsTab0507022List = new HashSet<FsTab0507022List>();
            FsTab0507022R2List = new HashSet<FsTab0507022R2List>();
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
        public string Namefed { get; set; }

        public virtual ICollection<FsTab0507022List> FsTab0507022List { get; set; }
        public virtual ICollection<FsTab0507022R2List> FsTab0507022R2List { get; set; }
    }
}
