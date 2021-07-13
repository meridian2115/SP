using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503130D
    {
        public DcArpReport0503130D()
        {
            Fs0503130SpravkaList = new HashSet<Fs0503130SpravkaList>();
            FsBa130BaSpravkaList = new HashSet<FsBa130BaSpravkaList>();
            FsBa19Ba130List = new HashSet<FsBa19Ba130List>();
            FsBa2019T0400503130List = new HashSet<FsBa2019T0400503130List>();
            FsBa2019T2000503130List = new HashSet<FsBa2019T2000503130List>();
            FsBa2021T0400503130List = new HashSet<FsBa2021T0400503130List>();
            FsBa2021T2000503130List = new HashSet<FsBa2021T2000503130List>();
            FsBa21Ba130List = new HashSet<FsBa21Ba130List>();
            FsT0100503130List = new HashSet<FsT0100503130List>();
            FsT0200503130List = new HashSet<FsT0200503130List>();
            FsT0300503130List = new HashSet<FsT0300503130List>();
            FsT0400503130List = new HashSet<FsT0400503130List>();
            FsT0500503130List = new HashSet<FsT0500503130List>();
            FsT10503130List = new HashSet<FsT10503130List>();
            FsT1200503130List = new HashSet<FsT1200503130List>();
            FsT1900503130List = new HashSet<FsT1900503130List>();
            FsT2000503130List = new HashSet<FsT2000503130List>();
            FsT20503130List = new HashSet<FsT20503130List>();
            FsT2200503130List = new HashSet<FsT2200503130List>();
            FsT2300503130List = new HashSet<FsT2300503130List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string ExecuterTel { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public DateTime? Date01012018 { get; set; }

        public virtual ICollection<Fs0503130SpravkaList> Fs0503130SpravkaList { get; set; }
        public virtual ICollection<FsBa130BaSpravkaList> FsBa130BaSpravkaList { get; set; }
        public virtual ICollection<FsBa19Ba130List> FsBa19Ba130List { get; set; }
        public virtual ICollection<FsBa2019T0400503130List> FsBa2019T0400503130List { get; set; }
        public virtual ICollection<FsBa2019T2000503130List> FsBa2019T2000503130List { get; set; }
        public virtual ICollection<FsBa2021T0400503130List> FsBa2021T0400503130List { get; set; }
        public virtual ICollection<FsBa2021T2000503130List> FsBa2021T2000503130List { get; set; }
        public virtual ICollection<FsBa21Ba130List> FsBa21Ba130List { get; set; }
        public virtual ICollection<FsT0100503130List> FsT0100503130List { get; set; }
        public virtual ICollection<FsT0200503130List> FsT0200503130List { get; set; }
        public virtual ICollection<FsT0300503130List> FsT0300503130List { get; set; }
        public virtual ICollection<FsT0400503130List> FsT0400503130List { get; set; }
        public virtual ICollection<FsT0500503130List> FsT0500503130List { get; set; }
        public virtual ICollection<FsT10503130List> FsT10503130List { get; set; }
        public virtual ICollection<FsT1200503130List> FsT1200503130List { get; set; }
        public virtual ICollection<FsT1900503130List> FsT1900503130List { get; set; }
        public virtual ICollection<FsT2000503130List> FsT2000503130List { get; set; }
        public virtual ICollection<FsT20503130List> FsT20503130List { get; set; }
        public virtual ICollection<FsT2200503130List> FsT2200503130List { get; set; }
        public virtual ICollection<FsT2300503130List> FsT2300503130List { get; set; }
    }
}
