using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpfinlinv0503171
    {
        public DcArpfinlinv0503171()
        {
            FsBeExp0503171List = new HashSet<FsBeExp0503171List>();
            FsItogExp0503171List = new HashSet<FsItogExp0503171List>();
            FsItogFin0503171List = new HashSet<FsItogFin0503171List>();
            FsPrint0503171List = new HashSet<FsPrint0503171List>();
            FsSfFin0503171List = new HashSet<FsSfFin0503171List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? BeC2R200 { get; set; }
        public decimal? SfC2R500 { get; set; }
        public string SgnsPfnLeader { get; set; }
        public string SgnsPfnChiefAcc { get; set; }
        public string SgnsPfnLeaderOfFes { get; set; }
        public string SgnsPfnPostLeader { get; set; }
        public string SgnsPfnPostChiefAcc { get; set; }
        public string SgnsPfnPostLeaderOf { get; set; }
        public string SgnsPfnExecutor { get; set; }
        public string SgnsPfnPostExecutor { get; set; }
        public string SgnsPfnPhone { get; set; }
        public string Ord { get; set; }
        public decimal? C2R800 { get; set; }
        public string TelIsp { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsBeExp0503171List> FsBeExp0503171List { get; set; }
        public virtual ICollection<FsItogExp0503171List> FsItogExp0503171List { get; set; }
        public virtual ICollection<FsItogFin0503171List> FsItogFin0503171List { get; set; }
        public virtual ICollection<FsPrint0503171List> FsPrint0503171List { get; set; }
        public virtual ICollection<FsSfFin0503171List> FsSfFin0503171List { get; set; }
    }
}
