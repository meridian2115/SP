using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport05033732019
    {
        public DcArpReport05033732019()
        {
            FsActiveR10503373List = new HashSet<FsActiveR10503373List>();
            FsActiveR30503373List = new HashSet<FsActiveR30503373List>();
            FsPassiveR20503373List = new HashSet<FsPassiveR20503373List>();
            FsPassiveR30503373List = new HashSet<FsPassiveR30503373List>();
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

        public virtual ICollection<FsActiveR10503373List> FsActiveR10503373List { get; set; }
        public virtual ICollection<FsActiveR30503373List> FsActiveR30503373List { get; set; }
        public virtual ICollection<FsPassiveR20503373List> FsPassiveR20503373List { get; set; }
        public virtual ICollection<FsPassiveR30503373List> FsPassiveR30503373List { get; set; }
    }
}
