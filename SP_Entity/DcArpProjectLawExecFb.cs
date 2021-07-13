using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpProjectLawExecFb
    {
        public DcArpProjectLawExecFb()
        {
            FsPlefbSec1List = new HashSet<FsPlefbSec1List>();
            FsPlefbSec2List = new HashSet<FsPlefbSec2List>();
            FsPlefbSec3List = new HashSet<FsPlefbSec3List>();
            FsPlefbSec4List = new HashSet<FsPlefbSec4List>();
            FsPlefbSec5List = new HashSet<FsPlefbSec5List>();
            FsPlefbSec6List = new HashSet<FsPlefbSec6List>();
            FsPlefbSec7List = new HashSet<FsPlefbSec7List>();
            FsPlefbSec8List = new HashSet<FsPlefbSec8List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string Surrogat { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string SeTel { get; set; }
        public DateTime? Year { get; set; }
        public decimal? Totalcashexec1 { get; set; }
        public decimal? Totalcashexec2 { get; set; }
        public decimal? Totalcashexec3 { get; set; }
        public decimal? Totalcashexec4 { get; set; }
        public decimal? Totalcashexec5 { get; set; }
        public decimal? Totalcashexec6 { get; set; }
        public decimal? Totalcashexec7 { get; set; }
        public decimal? Totalcashexec8 { get; set; }

        public virtual ICollection<FsPlefbSec1List> FsPlefbSec1List { get; set; }
        public virtual ICollection<FsPlefbSec2List> FsPlefbSec2List { get; set; }
        public virtual ICollection<FsPlefbSec3List> FsPlefbSec3List { get; set; }
        public virtual ICollection<FsPlefbSec4List> FsPlefbSec4List { get; set; }
        public virtual ICollection<FsPlefbSec5List> FsPlefbSec5List { get; set; }
        public virtual ICollection<FsPlefbSec6List> FsPlefbSec6List { get; set; }
        public virtual ICollection<FsPlefbSec7List> FsPlefbSec7List { get; set; }
        public virtual ICollection<FsPlefbSec8List> FsPlefbSec8List { get; set; }
    }
}
