using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFamRegofpaymentsD05
    {
        public DcFamRegofpaymentsD05()
        {
            FsContentrnpD05List = new HashSet<FsContentrnpD05List>();
            FsLaAgrD05List = new HashSet<FsLaAgrD05List>();
            FsLaAppD05List = new HashSet<FsLaAppD05List>();
            FsLaExecD05List = new HashSet<FsLaExecD05List>();
            FsOebsErrorsD05List = new HashSet<FsOebsErrorsD05List>();
            FsOebsLogList = new HashSet<FsOebsLogList>();
            FsXmlFilesList = new HashSet<FsXmlFilesList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string BreEdno { get; set; }
        public DateTime? BreEddate { get; set; }
        public string BreEdauthor { get; set; }
        public string BreEdreceiver { get; set; }
        public string BreDocnum { get; set; }
        public DateTime? BreDocdate { get; set; }
        public string BreDocguid { get; set; }
        public string BreBankacc { get; set; }
        public string BreSendtime { get; set; }
        public DateTime? BrePaydate { get; set; }
        public string BreTemplateid { get; set; }
        public string BrePayordermax { get; set; }
        public string BrePayordermin { get; set; }
        public decimal? BreSumregistrymax { get; set; }
        public string BreReqtype { get; set; }
        public string BrePayview { get; set; }
        public string BreNumofpaymmax { get; set; }
        public string BreNumofpayminc { get; set; }
        public decimal? BreSumregistry { get; set; }
        public string BreGuidattach { get; set; }
        public string BreTofkcode { get; set; }
        public string BreCreateorg { get; set; }
        public string SignChiefAcc { get; set; }
        public string SignPostChiefAcc { get; set; }
        public string SignExecutor { get; set; }
        public string SignPostExecutor { get; set; }
        public string SignPhone { get; set; }
        public string SignLeader { get; set; }
        public string SignPostLeader { get; set; }
        public DateTime? SignData { get; set; }
        public DateTime? SignDatesignexec { get; set; }
        public DateTime? SignDatesignldr { get; set; }
        public DateTime? SignDatesignacc { get; set; }
        public string TfBankacc { get; set; }
        public string TfBik { get; set; }
        public string TfCorracc { get; set; }
        public string TfBankname { get; set; }
        public DateTime? TfPaydate { get; set; }
        public decimal? TfSumregistrymax { get; set; }
        public string TfPayordermax { get; set; }
        public string TfPayordermin { get; set; }
        public string TfPayview { get; set; }
        public string TfPayviewtext { get; set; }
        public string TfSumtext { get; set; }
        public string TfNumofpaymmax { get; set; }
        public decimal? TfNumselectrows { get; set; }
        public string TfErrortext { get; set; }
        public string TfReturnstatus { get; set; }
        public string TfClobfield { get; set; }
        public string TfInsufficientfunds { get; set; }
        public string TfJustcreated { get; set; }
        public string TfReturnsratuscreate { get; set; }
        public string TfReturnsratusexec { get; set; }
        public string TfPpcancelcheck { get; set; }
        public string TfUserinittransition { get; set; }
        public string ScadStatussign { get; set; }
        public string ScadStatusnmsign { get; set; }
        public string ScadUserfiozk { get; set; }
        public string ScadUserpostzk { get; set; }
        public string ScadUserfioka { get; set; }
        public string ScadUserpostka { get; set; }
        public string ErCode { get; set; }
        public string ErText { get; set; }
        public bool? LaSkipappr { get; set; }
        public string LaAmountrowexecutor { get; set; }
        public string LaAmountrowagreer { get; set; }
        public string LaAmountrowapprover { get; set; }

        public virtual ICollection<FsContentrnpD05List> FsContentrnpD05List { get; set; }
        public virtual ICollection<FsLaAgrD05List> FsLaAgrD05List { get; set; }
        public virtual ICollection<FsLaAppD05List> FsLaAppD05List { get; set; }
        public virtual ICollection<FsLaExecD05List> FsLaExecD05List { get; set; }
        public virtual ICollection<FsOebsErrorsD05List> FsOebsErrorsD05List { get; set; }
        public virtual ICollection<FsOebsLogList> FsOebsLogList { get; set; }
        public virtual ICollection<FsXmlFilesList> FsXmlFilesList { get; set; }
    }
}
