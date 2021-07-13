using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507061
    {
        public DcArpReport0507061()
        {
            FsT1061List = new HashSet<FsT1061List>();
            FsT2061List = new HashSet<FsT2061List>();
            FsT3061List = new HashSet<FsT3061List>();
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

        public virtual ICollection<FsT1061List> FsT1061List { get; set; }
        public virtual ICollection<FsT2061List> FsT2061List { get; set; }
        public virtual ICollection<FsT3061List> FsT3061List { get; set; }
    }
}
