using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504071
    {
        public DcArpFah0504071()
        {
            Fs0504071List = new HashSet<Fs0504071List>();
            FsAp0504071List = new HashSet<FsAp0504071List>();
            FsHGScrDList = new HashSet<FsHGScrDList>();
            FsHGSdrDList = new HashSet<FsHGSdrDList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PReportSet { get; set; }
        public string Typecalcn { get; set; }
        public string PRptSetCode { get; set; }
        public string Repshouldn { get; set; }
        public string PTofkOpenCode { get; set; }
        public string PBudgetLevelCode { get; set; }
        public string Levelbudgn { get; set; }
        public string PBudgetTypeCode { get; set; }
        public string PBudgetCode { get; set; }
        public string PPostStatus { get; set; }
        public string Wirrepn { get; set; }
        public string PJournalNum { get; set; }
        public string PVsBudget { get; set; }
        public string PFundSource { get; set; }
        public string PAccDb { get; set; }
        public string PAccCr { get; set; }
        public string PSegment2 { get; set; }
        public string PKosgu { get; set; }
        public string PSegment7 { get; set; }
        public string POrderKosgu { get; set; }
        public string Sortkosgun { get; set; }
        public DateTime? PReportDate { get; set; }
        public string PShowAcc { get; set; }
        public string PAccGroup { get; set; }
        public string PDocGroupType { get; set; }
        public string Detailn { get; set; }
        public string PSeparateRep { get; set; }
        public string PSegment { get; set; }
        public string Contourn { get; set; }
        public string PAlwaysPrintFlag { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PFormatTxt { get; set; }
        public string PXmlFormat { get; set; }
        public string StatusName { get; set; }
        public string PhaseName { get; set; }
        public string CompletionText { get; set; }
        public DateTime? PBeginGlDate { get; set; }
        public DateTime? PEndGlDate { get; set; }
        public string PSuFinOrg { get; set; }
        public string PReportType { get; set; }
        public string PReportform { get; set; }
        public string PReportformCode { get; set; }
        public string PSubsistemKey { get; set; }
        public string PProgram { get; set; }
        public string PConsiderToPeriod { get; set; }
        public string PDistrPayments { get; set; }
        public string PSegm10 { get; set; }
        public string PSegm10t { get; set; }
        public string PLedgerSet { get; set; }
        public string PLedger { get; set; }
        public string PVsFundSource { get; set; }
        public string PTofkCode { get; set; }
        public DateTime? PRptDate { get; set; }
        public string PLedgerId { get; set; }
        public string PVsSegment4 { get; set; }
        public string PDeptName { get; set; }
        public string PManagerPosition { get; set; }
        public string PManagerName { get; set; }
        public string PExecutorName { get; set; }
        public string PExecutorPosition { get; set; }
        public string PLedgerSetId { get; set; }
        public string PManagerRole { get; set; }
        public string PExecutorRole { get; set; }
        public string POebsLink { get; set; }
        public string HRjournalnum { get; set; }
        public string HRledgerdesc { get; set; }
        public string HRoperday { get; set; }
        public string HRdate1 { get; set; }
        public string HRokpo { get; set; }
        public string HRname { get; set; }
        public string HRdeptname { get; set; }
        public string HRbudgetname { get; set; }
        public string HRshowacc { get; set; }
        public string HTofk { get; set; }
        public decimal? GSopFR10 { get; set; }
        public decimal? GSdrFR10 { get; set; }
        public decimal? GScrFR10 { get; set; }
        public string ApLoginGb { get; set; }
        public string ApLoginRfes { get; set; }
        public string ApLoginR { get; set; }
        public string ApFioGb { get; set; }
        public string ApFioRfes { get; set; }
        public string ApFioR { get; set; }
        public string ApDepartmentGb { get; set; }
        public string ApDepartmentRfes { get; set; }
        public string ApDepartmentR { get; set; }
        public string ApPostfieldR { get; set; }
        public string ApPostfieldRfes { get; set; }
        public string ApPostfieldGb { get; set; }
        public bool? ApScipsoglas { get; set; }
        public string ApSoglasGb { get; set; }
        public string ApSoglasRfes { get; set; }
        public string ApSoglasR { get; set; }
        public string ApNoteGb { get; set; }
        public string ApNoteRfes { get; set; }
        public string ApNoteR { get; set; }
        public string ApPhone { get; set; }
        public string PReportDateT { get; set; }
        public string Inst { get; set; }
        public string ExecRes { get; set; }
        public string ManagRes { get; set; }
        public string Format { get; set; }
        public bool? PShowAccB { get; set; }
        public bool? PAccGroupB { get; set; }
        public bool? PSeparateRepB { get; set; }
        public bool? PAlwaysPrintFlagB { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string PUfosGuid { get; set; }
        public string HOkud { get; set; }
        public string HOkei { get; set; }
        public string Vr { get; set; }

        public virtual ICollection<Fs0504071List> Fs0504071List { get; set; }
        public virtual ICollection<FsAp0504071List> FsAp0504071List { get; set; }
        public virtual ICollection<FsHGScrDList> FsHGScrDList { get; set; }
        public virtual ICollection<FsHGSdrDList> FsHGSdrDList { get; set; }
    }
}
