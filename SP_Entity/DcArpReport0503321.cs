using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503321
    {
        public DcArpReport0503321()
        {
            FsR1T1321List = new HashSet<FsR1T1321List>();
            FsR2T2321List = new HashSet<FsR2T2321List>();
            FsR3T3321List = new HashSet<FsR3T3321List>();
            FsR4T4321List = new HashSet<FsR4T4321List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrPnfLeader { get; set; }
        public string HrPnfChiefAcc { get; set; }
        public string HrPnfLeaderOfFes { get; set; }
        public string HrPnfPostLeader { get; set; }
        public string HrPnfPostChiefAcc { get; set; }
        public string HrPnfPostLeaderOf { get; set; }
        public string HrPnfExecutor { get; set; }
        public string HrPnfPostExecutor { get; set; }
        public string HrPnfPhone { get; set; }
        public string HrOrd { get; set; }
        public string HrNamtip { get; set; }
        public DateTime? Dateminusday { get; set; }
        public DateTime? Year { get; set; }

        public virtual ICollection<FsR1T1321List> FsR1T1321List { get; set; }
        public virtual ICollection<FsR2T2321List> FsR2T2321List { get; set; }
        public virtual ICollection<FsR3T3321List> FsR3T3321List { get; set; }
        public virtual ICollection<FsR4T4321List> FsR4T4321List { get; set; }
    }
}
