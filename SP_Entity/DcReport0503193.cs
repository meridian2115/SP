using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503193
    {
        public DcReport0503193()
        {
            FsItogoAllList = new HashSet<FsItogoAllList>();
            FsItogoboList = new HashSet<FsItogoboList>();
            FsItogoinnList = new HashSet<FsItogoinnList>();
            FsPf0503193List = new HashSet<FsPf0503193List>();
            FsReportTable193List = new HashSet<FsReportTable193List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string SngSignLeader { get; set; }
        public string SngSignChiefAcc { get; set; }
        public string SngSignLeaderOfFes { get; set; }
        public string SngSignPostLeader { get; set; }
        public string SngSignPostChiefAcc { get; set; }
        public string SngSignPostLeaderOf { get; set; }
        public string SngSignExecutor { get; set; }
        public string SngSignPostExecutor { get; set; }
        public string SngSignPhone { get; set; }
        public string Ord { get; set; }
        public DateTime? Dateminusday { get; set; }
        public decimal? TotalItog { get; set; }
        public decimal? OverdueItog { get; set; }
        public decimal? TotalEndpItog { get; set; }
        public decimal? ConfnfItog { get; set; }
        public decimal? ArrearsItog { get; set; }
        public decimal? RepayfbItog { get; set; }
        public decimal? ScheduledDebtEndpItog { get; set; }
        public decimal? Year { get; set; }

        public virtual ICollection<FsItogoAllList> FsItogoAllList { get; set; }
        public virtual ICollection<FsItogoboList> FsItogoboList { get; set; }
        public virtual ICollection<FsItogoinnList> FsItogoinnList { get; set; }
        public virtual ICollection<FsPf0503193List> FsPf0503193List { get; set; }
        public virtual ICollection<FsReportTable193List> FsReportTable193List { get; set; }
    }
}
