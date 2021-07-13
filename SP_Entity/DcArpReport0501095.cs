using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0501095
    {
        public DcArpReport0501095()
        {
            FsR1095T1095List = new HashSet<FsR1095T1095List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
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
        public decimal? R1095C4R0 { get; set; }
        public decimal? R1095C5R0 { get; set; }
        public decimal? R1095C6R0 { get; set; }
        public decimal? R1095C70 { get; set; }
        public string ExecuterTel { get; set; }

        public virtual ICollection<FsR1095T1095List> FsR1095T1095List { get; set; }
    }
}
