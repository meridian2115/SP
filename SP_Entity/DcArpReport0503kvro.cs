using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503kvro
    {
        public DcArpReport0503kvro()
        {
            FsT100503kvroList = new HashSet<FsT100503kvroList>();
            FsT10503kvroList = new HashSet<FsT10503kvroList>();
            FsT110503kvroList = new HashSet<FsT110503kvroList>();
            FsT20503kvroList = new HashSet<FsT20503kvroList>();
            FsT30503kvroList = new HashSet<FsT30503kvroList>();
            FsT40503kvroList = new HashSet<FsT40503kvroList>();
            FsT50503kvroList = new HashSet<FsT50503kvroList>();
            FsT70503kvroList = new HashSet<FsT70503kvroList>();
            FsT80503kvroList = new HashSet<FsT80503kvroList>();
            FsT90503kvroList = new HashSet<FsT90503kvroList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public decimal? C4aR1 { get; set; }
        public decimal? C4aR2 { get; set; }
        public decimal? C4aR3 { get; set; }
        public decimal? C4aR4 { get; set; }
        public decimal? C4aR5 { get; set; }
        public decimal? C4aR7 { get; set; }
        public decimal? C4aR8 { get; set; }
        public decimal? C4aR9 { get; set; }
        public decimal? C4aR10 { get; set; }
        public decimal? C4aR11 { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }

        public virtual ICollection<FsT100503kvroList> FsT100503kvroList { get; set; }
        public virtual ICollection<FsT10503kvroList> FsT10503kvroList { get; set; }
        public virtual ICollection<FsT110503kvroList> FsT110503kvroList { get; set; }
        public virtual ICollection<FsT20503kvroList> FsT20503kvroList { get; set; }
        public virtual ICollection<FsT30503kvroList> FsT30503kvroList { get; set; }
        public virtual ICollection<FsT40503kvroList> FsT40503kvroList { get; set; }
        public virtual ICollection<FsT50503kvroList> FsT50503kvroList { get; set; }
        public virtual ICollection<FsT70503kvroList> FsT70503kvroList { get; set; }
        public virtual ICollection<FsT80503kvroList> FsT80503kvroList { get; set; }
        public virtual ICollection<FsT90503kvroList> FsT90503kvroList { get; set; }
    }
}
