using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05031732019
    {
        public DcArpReport05031732019()
        {
            FsAcR11732020List = new HashSet<FsAcR11732020List>();
            FsActiveR10503173List = new HashSet<FsActiveR10503173List>();
            FsActiveR30503173List = new HashSet<FsActiveR30503173List>();
            FsPasR21732020List = new HashSet<FsPasR21732020List>();
            FsPassiveR20503173List = new HashSet<FsPassiveR20503173List>();
            FsPassiveR30503173List = new HashSet<FsPassiveR30503173List>();
            FsZbsZsR4List = new HashSet<FsZbsZsR4List>();
            FsZsT0400503173List = new HashSet<FsZsT0400503173List>();
            FsZsT2000503173List = new HashSet<FsZsT2000503173List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C2R3Act { get; set; }
        public decimal? C2R3Pas { get; set; }
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

        public virtual ICollection<FsAcR11732020List> FsAcR11732020List { get; set; }
        public virtual ICollection<FsActiveR10503173List> FsActiveR10503173List { get; set; }
        public virtual ICollection<FsActiveR30503173List> FsActiveR30503173List { get; set; }
        public virtual ICollection<FsPasR21732020List> FsPasR21732020List { get; set; }
        public virtual ICollection<FsPassiveR20503173List> FsPassiveR20503173List { get; set; }
        public virtual ICollection<FsPassiveR30503173List> FsPassiveR30503173List { get; set; }
        public virtual ICollection<FsZbsZsR4List> FsZbsZsR4List { get; set; }
        public virtual ICollection<FsZsT0400503173List> FsZsT0400503173List { get; set; }
        public virtual ICollection<FsZsT2000503173List> FsZsT2000503173List { get; set; }
    }
}
