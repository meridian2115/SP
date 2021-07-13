using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503123
    {
        public DcArpReport0503123()
        {
            FsC1T1List = new HashSet<FsC1T1List>();
            FsC2T2List = new HashSet<FsC2T2List>();
            FsC31Inflow123List = new HashSet<FsC31Inflow123List>();
            FsC31Outflow123List = new HashSet<FsC31Outflow123List>();
            FsC3T3List = new HashSet<FsC3T3List>();
            FsC418Exp18123List = new HashSet<FsC418Exp18123List>();
            FsC418Return123List = new HashSet<FsC418Return123List>();
            FsC4Expense123List = new HashSet<FsC4Expense123List>();
            FsC4Opercash123List = new HashSet<FsC4Opercash123List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? C31SumR31800 { get; set; }
        public decimal? C31SumR31810 { get; set; }
        public decimal? C31SumR31820 { get; set; }
        public string C31Cdsubsec810 { get; set; }
        public string C31C4aR810 { get; set; }
        public string C31C4bR810 { get; set; }
        public string C31Cdsubsec820 { get; set; }
        public string C31C4aR820 { get; set; }
        public string C31C4bR820 { get; set; }
        public decimal? C418SumR4900 { get; set; }
        public decimal? C418SumR4980 { get; set; }
        public decimal? C418SumR4990 { get; set; }
        public string C418Cdsubsec990 { get; set; }
        public string C418Kvr990 { get; set; }
        public decimal? C4SumR4900 { get; set; }
        public decimal? C4SumR4980 { get; set; }
        public decimal? C4SumR4990 { get; set; }
        public string C4Cdsubsec980 { get; set; }
        public string C4Cdsubsec990 { get; set; }
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
        public string HrTelephone { get; set; }
        public DateTime? Dateminusyear { get; set; }

        public virtual ICollection<FsC1T1List> FsC1T1List { get; set; }
        public virtual ICollection<FsC2T2List> FsC2T2List { get; set; }
        public virtual ICollection<FsC31Inflow123List> FsC31Inflow123List { get; set; }
        public virtual ICollection<FsC31Outflow123List> FsC31Outflow123List { get; set; }
        public virtual ICollection<FsC3T3List> FsC3T3List { get; set; }
        public virtual ICollection<FsC418Exp18123List> FsC418Exp18123List { get; set; }
        public virtual ICollection<FsC418Return123List> FsC418Return123List { get; set; }
        public virtual ICollection<FsC4Expense123List> FsC4Expense123List { get; set; }
        public virtual ICollection<FsC4Opercash123List> FsC4Opercash123List { get; set; }
    }
}
