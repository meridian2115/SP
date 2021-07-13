using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503723
    {
        public DcArpReport0503723()
        {
            FsC1T1723List = new HashSet<FsC1T1723List>();
            FsC2T2723List = new HashSet<FsC2T2723List>();
            FsC3T3723List = new HashSet<FsC3T3723List>();
            FsC4Expense723List = new HashSet<FsC4Expense723List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C4Sum900 { get; set; }
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
        public DateTime? Dateminusyear { get; set; }
        public DateTime? Year { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public bool? SubDiv { get; set; }

        public virtual ICollection<FsC1T1723List> FsC1T1723List { get; set; }
        public virtual ICollection<FsC2T2723List> FsC2T2723List { get; set; }
        public virtual ICollection<FsC3T3723List> FsC3T3723List { get; set; }
        public virtual ICollection<FsC4Expense723List> FsC4Expense723List { get; set; }
    }
}
