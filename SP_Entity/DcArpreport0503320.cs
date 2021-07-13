using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpreport0503320
    {
        public DcArpreport0503320()
        {
            FsBaT0100503320List = new HashSet<FsBaT0100503320List>();
            FsBaT0200503320List = new HashSet<FsBaT0200503320List>();
            FsBaT0300503320List = new HashSet<FsBaT0300503320List>();
            FsBaT04005033202019List = new HashSet<FsBaT04005033202019List>();
            FsBaT0400503320List = new HashSet<FsBaT0400503320List>();
            FsBaT0500503320List = new HashSet<FsBaT0500503320List>();
            FsBaT1200503320List = new HashSet<FsBaT1200503320List>();
            FsBaT1900503320List = new HashSet<FsBaT1900503320List>();
            FsBaT20005033202019List = new HashSet<FsBaT20005033202019List>();
            FsBaT2000503320List = new HashSet<FsBaT2000503320List>();
            FsBaT2200503320List = new HashSet<FsBaT2200503320List>();
            FsBaT2300503320List = new HashSet<FsBaT2300503320List>();
            FsBaTab0503320ba2019List = new HashSet<FsBaTab0503320ba2019List>();
            FsBaTab0503320baList = new HashSet<FsBaTab0503320baList>();
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
        public string ExecutorTel { get; set; }
        public string Countert0402019 { get; set; }
        public string Countert2002019 { get; set; }

        public virtual ICollection<FsBaT0100503320List> FsBaT0100503320List { get; set; }
        public virtual ICollection<FsBaT0200503320List> FsBaT0200503320List { get; set; }
        public virtual ICollection<FsBaT0300503320List> FsBaT0300503320List { get; set; }
        public virtual ICollection<FsBaT04005033202019List> FsBaT04005033202019List { get; set; }
        public virtual ICollection<FsBaT0400503320List> FsBaT0400503320List { get; set; }
        public virtual ICollection<FsBaT0500503320List> FsBaT0500503320List { get; set; }
        public virtual ICollection<FsBaT1200503320List> FsBaT1200503320List { get; set; }
        public virtual ICollection<FsBaT1900503320List> FsBaT1900503320List { get; set; }
        public virtual ICollection<FsBaT20005033202019List> FsBaT20005033202019List { get; set; }
        public virtual ICollection<FsBaT2000503320List> FsBaT2000503320List { get; set; }
        public virtual ICollection<FsBaT2200503320List> FsBaT2200503320List { get; set; }
        public virtual ICollection<FsBaT2300503320List> FsBaT2300503320List { get; set; }
        public virtual ICollection<FsBaTab0503320ba2019List> FsBaTab0503320ba2019List { get; set; }
        public virtual ICollection<FsBaTab0503320baList> FsBaTab0503320baList { get; set; }
    }
}
