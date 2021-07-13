using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507020
    {
        public DcArpReport0507020()
        {
            FsTyperep020aList = new HashSet<FsTyperep020aList>();
            FsTyperep020rList = new HashSet<FsTyperep020rList>();
            FsTypereport020List = new HashSet<FsTypereport020List>();
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

        public virtual ICollection<FsTyperep020aList> FsTyperep020aList { get; set; }
        public virtual ICollection<FsTyperep020rList> FsTyperep020rList { get; set; }
        public virtual ICollection<FsTypereport020List> FsTypereport020List { get; set; }
    }
}
