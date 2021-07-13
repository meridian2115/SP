using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503121D
    {
        public DcArpReport0503121D()
        {
            FsAct0503121List = new HashSet<FsAct0503121List>();
            FsBe0503121List = new HashSet<FsBe0503121List>();
            FsBr0503121List = new HashSet<FsBr0503121List>();
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
        public string ExecutorTel { get; set; }
        public DateTime? Date01012018 { get; set; }

        public virtual ICollection<FsAct0503121List> FsAct0503121List { get; set; }
        public virtual ICollection<FsBe0503121List> FsBe0503121List { get; set; }
        public virtual ICollection<FsBr0503121List> FsBr0503121List { get; set; }
    }
}
