using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpMonitoring
    {
        public DcArpMonitoring()
        {
            FsKsTabMErrDList = new HashSet<FsKsTabMErrDList>();
            FsKsTabMErrFlkList = new HashSet<FsKsTabMErrFlkList>();
            FsKsTabMErrList = new HashSet<FsKsTabMErrList>();
            FsKsTabMErrMdkList = new HashSet<FsKsTabMErrMdkList>();
            FsKsTabMErrSubList = new HashSet<FsKsTabMErrSubList>();
            FsKsTabMErrSubRepList = new HashSet<FsKsTabMErrSubRepList>();
            FsKsTabMErrVdkList = new HashSet<FsKsTabMErrVdkList>();
            FsKsTabMTopFlkList = new HashSet<FsKsTabMTopFlkList>();
            FsKsTabMTopMdkList = new HashSet<FsKsTabMTopMdkList>();
            FsKsTabMTopSub2List = new HashSet<FsKsTabMTopSub2List>();
            FsKsTabMTopSubList = new HashSet<FsKsTabMTopSubList>();
            FsKsTabMTopVdkList = new HashSet<FsKsTabMTopVdkList>();
            FsTabMonitoringList = new HashSet<FsTabMonitoringList>();
            FsTabMonitoringRepDList = new HashSet<FsTabMonitoringRepDList>();
            FsTabMonitoringRepList = new HashSet<FsTabMonitoringRepList>();
            FsTabMonitoringRepTList = new HashSet<FsTabMonitoringRepTList>();
            FsTabMonitoringTList = new HashSet<FsTabMonitoringTList>();
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
        public string Tofk { get; set; }
        public string SetsOfRep { get; set; }
        public string SetsOfRepCd { get; set; }
        public string CdSubOfEnt { get; set; }
        public string CountSub { get; set; }
        public string CountRep { get; set; }
        public string FinishCount { get; set; }
        public string InProgressCount { get; set; }
        public string StartCount { get; set; }
        public string FinishPercent { get; set; }
        public string InProgressPercent { get; set; }
        public string StartPercent { get; set; }
        public string FinishCountRep { get; set; }
        public string InProgressCountRep { get; set; }
        public string StartCountRep { get; set; }
        public string FinishPercentRep { get; set; }
        public string InProgressPercentRep { get; set; }
        public string StartPercentRep { get; set; }
        public string SysnameForm { get; set; }
        public string Title { get; set; }
        public string Title1 { get; set; }
        public string AccCd { get; set; }
        public bool? Pbs { get; set; }
        public bool? Aubu { get; set; }
        public string Naimpechat { get; set; }
        public string Naimpechat2 { get; set; }
        public string DlgNmSub { get; set; }
        public string DlgCdSub { get; set; }
        public string DlgSetsOfRepCd { get; set; }
        public DateTime? DlgSbmtDate { get; set; }
        public string TableType { get; set; }
        public string TypeSub { get; set; }
        public string Month { get; set; }
        public string CodeformLength { get; set; }
        public bool? FlagKs { get; set; }
        public string KsCountSub { get; set; }
        public string KsCountSubErr1 { get; set; }
        public string KsCountSubErr2 { get; set; }
        public string KsCountRep { get; set; }
        public string KsCountRepError { get; set; }
        public string KsCountRepPrcnt { get; set; }
        public decimal? KsCountRepErrorPrcnt { get; set; }
        public string KsCountRepErrorPrcnt1 { get; set; }
        public string KsCountRepErrorPrcnt2 { get; set; }
        public string KsVdk { get; set; }
        public string KsVdkPrcnt { get; set; }
        public string KsMdk { get; set; }
        public string KsMdkPrcnt { get; set; }
        public string KsFlk { get; set; }
        public string KsFlkPrcnt { get; set; }
        public string KsTitle { get; set; }
        public string KsTableType { get; set; }
        public string KsCodecr { get; set; }
        public string KsDlgNmSub { get; set; }
        public string KsDlgCdSub { get; set; }
        public decimal? KsKsCount { get; set; }
        public string UserInstCode { get; set; }
        public DateTime? DateForm { get; set; }
        public string BkCodes { get; set; }
        public decimal? Startform { get; set; }
        public decimal? StartformErr { get; set; }
        public string Formstate { get; set; }
        public string CodeformsCopy { get; set; }
        public string CbInstCode { get; set; }

        public virtual ICollection<FsKsTabMErrDList> FsKsTabMErrDList { get; set; }
        public virtual ICollection<FsKsTabMErrFlkList> FsKsTabMErrFlkList { get; set; }
        public virtual ICollection<FsKsTabMErrList> FsKsTabMErrList { get; set; }
        public virtual ICollection<FsKsTabMErrMdkList> FsKsTabMErrMdkList { get; set; }
        public virtual ICollection<FsKsTabMErrSubList> FsKsTabMErrSubList { get; set; }
        public virtual ICollection<FsKsTabMErrSubRepList> FsKsTabMErrSubRepList { get; set; }
        public virtual ICollection<FsKsTabMErrVdkList> FsKsTabMErrVdkList { get; set; }
        public virtual ICollection<FsKsTabMTopFlkList> FsKsTabMTopFlkList { get; set; }
        public virtual ICollection<FsKsTabMTopMdkList> FsKsTabMTopMdkList { get; set; }
        public virtual ICollection<FsKsTabMTopSub2List> FsKsTabMTopSub2List { get; set; }
        public virtual ICollection<FsKsTabMTopSubList> FsKsTabMTopSubList { get; set; }
        public virtual ICollection<FsKsTabMTopVdkList> FsKsTabMTopVdkList { get; set; }
        public virtual ICollection<FsTabMonitoringList> FsTabMonitoringList { get; set; }
        public virtual ICollection<FsTabMonitoringRepDList> FsTabMonitoringRepDList { get; set; }
        public virtual ICollection<FsTabMonitoringRepList> FsTabMonitoringRepList { get; set; }
        public virtual ICollection<FsTabMonitoringRepTList> FsTabMonitoringRepTList { get; set; }
        public virtual ICollection<FsTabMonitoringTList> FsTabMonitoringTList { get; set; }
    }
}
