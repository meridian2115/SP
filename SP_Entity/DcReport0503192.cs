using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503192
    {
        public DcReport0503192()
        {
            FsItogiKsList = new HashSet<FsItogiKsList>();
            FsItogiList = new HashSet<FsItogiList>();
            FsItogicontragentList = new HashSet<FsItogicontragentList>();
            FsItogivsegoList = new HashSet<FsItogivsegoList>();
            FsPf0503192List = new HashSet<FsPf0503192List>();
            FsReportTableList = new HashSet<FsReportTableList>();
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
        public string Telephone { get; set; }

        public virtual ICollection<FsItogiKsList> FsItogiKsList { get; set; }
        public virtual ICollection<FsItogiList> FsItogiList { get; set; }
        public virtual ICollection<FsItogicontragentList> FsItogicontragentList { get; set; }
        public virtual ICollection<FsItogivsegoList> FsItogivsegoList { get; set; }
        public virtual ICollection<FsPf0503192List> FsPf0503192List { get; set; }
        public virtual ICollection<FsReportTableList> FsReportTableList { get; set; }
    }
}
