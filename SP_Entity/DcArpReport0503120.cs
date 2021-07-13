using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503120
    {
        public DcArpReport0503120()
        {
            FsBa19Ba120List = new HashSet<FsBa19Ba120List>();
            FsBa19T040130List = new HashSet<FsBa19T040130List>();
            FsBa19T200120List = new HashSet<FsBa19T200120List>();
            FsBaT0100503120List = new HashSet<FsBaT0100503120List>();
            FsBaT0200503120List = new HashSet<FsBaT0200503120List>();
            FsBaT0300503120List = new HashSet<FsBaT0300503120List>();
            FsBaT0400503120List = new HashSet<FsBaT0400503120List>();
            FsBaT0500503120List = new HashSet<FsBaT0500503120List>();
            FsBaT1200503120List = new HashSet<FsBaT1200503120List>();
            FsBaT1900503120List = new HashSet<FsBaT1900503120List>();
            FsBaT2000503120List = new HashSet<FsBaT2000503120List>();
            FsBaT2100503120List = new HashSet<FsBaT2100503120List>();
            FsBaT2300503120List = new HashSet<FsBaT2300503120List>();
            FsBaTab0503120baList = new HashSet<FsBaTab0503120baList>();
            FsT10503120List = new HashSet<FsT10503120List>();
            FsT20503120List = new HashSet<FsT20503120List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public string BaCountsum010 { get; set; }
        public string BaCountsum020 { get; set; }
        public string BaCountsum030 { get; set; }
        public string BaCountsum040 { get; set; }
        public string BaCountsum050 { get; set; }
        public string BaCountsum120 { get; set; }
        public string BaCountsum190 { get; set; }
        public string BaCountsum200 { get; set; }
        public string BaCountsum210 { get; set; }
        public string BaCountsum230 { get; set; }
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
        public string TelIsp { get; set; }
        public string Zksign { get; set; }

        public virtual ICollection<FsBa19Ba120List> FsBa19Ba120List { get; set; }
        public virtual ICollection<FsBa19T040130List> FsBa19T040130List { get; set; }
        public virtual ICollection<FsBa19T200120List> FsBa19T200120List { get; set; }
        public virtual ICollection<FsBaT0100503120List> FsBaT0100503120List { get; set; }
        public virtual ICollection<FsBaT0200503120List> FsBaT0200503120List { get; set; }
        public virtual ICollection<FsBaT0300503120List> FsBaT0300503120List { get; set; }
        public virtual ICollection<FsBaT0400503120List> FsBaT0400503120List { get; set; }
        public virtual ICollection<FsBaT0500503120List> FsBaT0500503120List { get; set; }
        public virtual ICollection<FsBaT1200503120List> FsBaT1200503120List { get; set; }
        public virtual ICollection<FsBaT1900503120List> FsBaT1900503120List { get; set; }
        public virtual ICollection<FsBaT2000503120List> FsBaT2000503120List { get; set; }
        public virtual ICollection<FsBaT2100503120List> FsBaT2100503120List { get; set; }
        public virtual ICollection<FsBaT2300503120List> FsBaT2300503120List { get; set; }
        public virtual ICollection<FsBaTab0503120baList> FsBaTab0503120baList { get; set; }
        public virtual ICollection<FsT10503120List> FsT10503120List { get; set; }
        public virtual ICollection<FsT20503120List> FsT20503120List { get; set; }
    }
}
