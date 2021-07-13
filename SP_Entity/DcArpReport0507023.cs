using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507023
    {
        public DcArpReport0507023()
        {
            FsTyperep023aList = new HashSet<FsTyperep023aList>();
            FsTyperep023rList = new HashSet<FsTyperep023rList>();
            FsTypereport023List = new HashSet<FsTypereport023List>();
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
        public decimal? Test { get; set; }

        public virtual ICollection<FsTyperep023aList> FsTyperep023aList { get; set; }
        public virtual ICollection<FsTyperep023rList> FsTyperep023rList { get; set; }
        public virtual ICollection<FsTypereport023List> FsTypereport023List { get; set; }
    }
}
