using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0531341
    {
        public DcArpReport0531341()
        {
            FsGbrsInfList = new HashSet<FsGbrsInfList>();
            FsGrbs341List = new HashSet<FsGrbs341List>();
            FsPbs341List = new HashSet<FsPbs341List>();
            FsTabprint341List = new HashSet<FsTabprint341List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? SumYearbeg { get; set; }
        public decimal? SumPeriodend { get; set; }
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
        public string HrTelIsp { get; set; }
        public DateTime? Currentdate { get; set; }

        public virtual ICollection<FsGbrsInfList> FsGbrsInfList { get; set; }
        public virtual ICollection<FsGrbs341List> FsGrbs341List { get; set; }
        public virtual ICollection<FsPbs341List> FsPbs341List { get; set; }
        public virtual ICollection<FsTabprint341List> FsTabprint341List { get; set; }
    }
}
