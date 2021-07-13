using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503127u
    {
        public DcArpReport0503127u()
        {
            FsRd1TR1127uList = new HashSet<FsRd1TR1127uList>();
            FsRd1TR1itog127uList = new HashSet<FsRd1TR1itog127uList>();
            FsRd2TR2127uList = new HashSet<FsRd2TR2127uList>();
            FsRd2TR2itog127uList = new HashSet<FsRd2TR2itog127uList>();
            FsRd3TR3127uList = new HashSet<FsRd3TR3127uList>();
            FsRd3TR3itog127uList = new HashSet<FsRd3TR3itog127uList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public decimal? Rd1Razd1itog1 { get; set; }
        public decimal? Rd1Razd1itog2 { get; set; }
        public decimal? Rd1Razd1itog3 { get; set; }
        public decimal? Rd2Razd2itog1 { get; set; }
        public decimal? Rd2Razd2itog2 { get; set; }
        public decimal? Rd2Razd2itog3 { get; set; }
        public decimal? Rd3Razd3itog1 { get; set; }
        public decimal? Rd3Razd3itog2 { get; set; }
        public decimal? Rd3Razd3itog3 { get; set; }
        public string PenLeader { get; set; }
        public string PenChiefAcc { get; set; }
        public string PenLeaderOfFes { get; set; }
        public string PenPostLeader { get; set; }
        public string PenPostChiefAcc { get; set; }
        public string PenPostLeaderOf { get; set; }
        public string PenExecutor { get; set; }
        public string PenPostExecutor { get; set; }
        public string PenPhone { get; set; }

        public virtual ICollection<FsRd1TR1127uList> FsRd1TR1127uList { get; set; }
        public virtual ICollection<FsRd1TR1itog127uList> FsRd1TR1itog127uList { get; set; }
        public virtual ICollection<FsRd2TR2127uList> FsRd2TR2127uList { get; set; }
        public virtual ICollection<FsRd2TR2itog127uList> FsRd2TR2itog127uList { get; set; }
        public virtual ICollection<FsRd3TR3127uList> FsRd3TR3127uList { get; set; }
        public virtual ICollection<FsRd3TR3itog127uList> FsRd3TR3itog127uList { get; set; }
    }
}
