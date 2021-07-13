using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0507019
    {
        public DcArpReport0507019()
        {
            FsAbTab10507019List = new HashSet<FsAbTab10507019List>();
            FsIbTab30507019List = new HashSet<FsIbTab30507019List>();
            FsIbTab3b0507019List = new HashSet<FsIbTab3b0507019List>();
            FsIbTab3c0507019List = new HashSet<FsIbTab3c0507019List>();
            FsIbTab3d0507019List = new HashSet<FsIbTab3d0507019List>();
            FsIbTab3e0507019List = new HashSet<FsIbTab3e0507019List>();
            FsIbTab3f0507019List = new HashSet<FsIbTab3f0507019List>();
            FsIbTab3g0507019List = new HashSet<FsIbTab3g0507019List>();
            FsPbTab20507019List = new HashSet<FsPbTab20507019List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
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
        public decimal? Test { get; set; }
        public string ExecuterTel { get; set; }

        public virtual ICollection<FsAbTab10507019List> FsAbTab10507019List { get; set; }
        public virtual ICollection<FsIbTab30507019List> FsIbTab30507019List { get; set; }
        public virtual ICollection<FsIbTab3b0507019List> FsIbTab3b0507019List { get; set; }
        public virtual ICollection<FsIbTab3c0507019List> FsIbTab3c0507019List { get; set; }
        public virtual ICollection<FsIbTab3d0507019List> FsIbTab3d0507019List { get; set; }
        public virtual ICollection<FsIbTab3e0507019List> FsIbTab3e0507019List { get; set; }
        public virtual ICollection<FsIbTab3f0507019List> FsIbTab3f0507019List { get; set; }
        public virtual ICollection<FsIbTab3g0507019List> FsIbTab3g0507019List { get; set; }
        public virtual ICollection<FsPbTab20507019List> FsPbTab20507019List { get; set; }
    }
}
