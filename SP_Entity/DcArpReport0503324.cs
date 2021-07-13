using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503324
    {
        public DcArpReport0503324()
        {
            FsR1T1324List = new HashSet<FsR1T1324List>();
            FsR2T1324List = new HashSet<FsR2T1324List>();
            FsR3T1324List = new HashSet<FsR3T1324List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? R1C5R1 { get; set; }
        public decimal? R1C6R1 { get; set; }
        public decimal? R1C7R1 { get; set; }
        public decimal? R1C8R1 { get; set; }
        public decimal? R1C9R1 { get; set; }
        public decimal? R1C10R1 { get; set; }
        public decimal? R1C11R1 { get; set; }
        public decimal? R1C12R1 { get; set; }
        public decimal? R1C13R1 { get; set; }
        public string R1Table1 { get; set; }
        public decimal? R2C4R2 { get; set; }
        public string SeLeader { get; set; }
        public string SeChiefAcc { get; set; }
        public string SeLeaderOfFes { get; set; }
        public string SePostLeader { get; set; }
        public string SePostChiefAcc { get; set; }
        public string SePostLeaderOf { get; set; }
        public string SeExecutor { get; set; }
        public string SePostExecutor { get; set; }
        public string SePhone { get; set; }
        public string Ord { get; set; }

        public virtual ICollection<FsR1T1324List> FsR1T1324List { get; set; }
        public virtual ICollection<FsR2T1324List> FsR2T1324List { get; set; }
        public virtual ICollection<FsR3T1324List> FsR3T1324List { get; set; }
    }
}
