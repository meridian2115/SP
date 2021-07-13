using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504072
    {
        public DcArpFah0504072()
        {
            FsAp0504072List = new HashSet<FsAp0504072List>();
            FsGNnList = new HashSet<FsGNnList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PReportSet { get; set; }
        public string Typecalcn { get; set; }
        public string PRptSetCode { get; set; }
        public string Repshouldn { get; set; }
        public DateTime? PBeginGlDate { get; set; }
        public DateTime? PEndGlDate { get; set; }
        public string PTofkOpenCode { get; set; }
        public string PBudgetLevelCode { get; set; }
        public string Levelbudgn { get; set; }
        public string PConsiderToPeriod { get; set; }
        public string PDistrPayments { get; set; }
        public string PSegm10 { get; set; }
        public string PSegm10n { get; set; }
        public string PLedgerSet { get; set; }
        public string PLedger { get; set; }
        public string PBudgetTypeCode { get; set; }
        public string PBudgetCode { get; set; }
        public string PSuFinOrg { get; set; }
        public string PVsBudget { get; set; }
        public string PFundSource { get; set; }
        public string PVsFundSource { get; set; }
        public string PPpp { get; set; }
        public string PSegment2 { get; set; }
        public string PKosgu { get; set; }
        public string PSegment7 { get; set; }
        public string PReorgBalance { get; set; }
        public string PReorgBalanceN { get; set; }
        public string PSumFlag { get; set; }
        public string PSumFlagn { get; set; }
        public string PAccCombination1 { get; set; }
        public string PReportType { get; set; }
        public string PReportTypenm { get; set; }
        public string PAccCombinationDetail { get; set; }
        public string PSubaccCombination1 { get; set; }
        public string PAccFormat1 { get; set; }
        public string PAccounts1 { get; set; }
        public string PSubaccCombination2 { get; set; }
        public string PAccFormat2 { get; set; }
        public string PAccounts2 { get; set; }
        public string PSubaccCombination3 { get; set; }
        public string PAccFormat3 { get; set; }
        public string PAccounts3 { get; set; }
        public string PSubaccCombination4 { get; set; }
        public string PAccFormat4 { get; set; }
        public string PAccounts4 { get; set; }
        public string PSubaccCombination5 { get; set; }
        public string PAccFormat5 { get; set; }
        public string PAccounts5 { get; set; }
        public string PFirstApprover { get; set; }
        public string PSecondApprover { get; set; }
        public string PThirdApprover { get; set; }
        public DateTime? PReportDate { get; set; }
        public string PCodeDate { get; set; }
        public string PSeparateRep { get; set; }
        public string PPositiveRep { get; set; }
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
        public string PSubsistemKey { get; set; }
        public string PResponsibilityKey { get; set; }
        public string PProgram { get; set; }
        public string PRespAapplicationShortName { get; set; }
        public string PUserName { get; set; }
        public string PReportform { get; set; }
        public string PReportformCode { get; set; }
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
        public string GReportDate { get; set; }
        public DateTime? GEndGlDate { get; set; }
        public string GOfficeName { get; set; }
        public DateTime? GCodeDate { get; set; }
        public string GNaimUch { get; set; }
        public string GPeriod { get; set; }
        public string GCurrencyCode { get; set; }
        public string GNaimDep { get; set; }
        public string GHRbudgetname { get; set; }
        public string GConstitutor { get; set; }
        public string GOkpo { get; set; }
        public string GTofk { get; set; }
        public string GTofkName { get; set; }
        public decimal? FSum1 { get; set; }
        public decimal? FSum2 { get; set; }
        public decimal? FSum3 { get; set; }
        public decimal? FSum4 { get; set; }
        public decimal? FSum5 { get; set; }
        public decimal? FSum6 { get; set; }
        public decimal? FSum7 { get; set; }
        public decimal? FSum8 { get; set; }
        public decimal? FSum9 { get; set; }
        public decimal? FSum10 { get; set; }
        public decimal? FSum91 { get; set; }
        public decimal? FSum101 { get; set; }
        public string FConcatenatedSegments { get; set; }
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
        public bool? PSeparateRepB { get; set; }
        public string Format { get; set; }
        public bool? PAlwaysPrintFlagB { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string InstCopy { get; set; }
        public string ExecRes { get; set; }
        public string ManagRes { get; set; }
        public string PUfosGuid { get; set; }
        public string HOkei { get; set; }
        public string Vr { get; set; }

        public virtual ICollection<FsAp0504072List> FsAp0504072List { get; set; }
        public virtual ICollection<FsGNnList> FsGNnList { get; set; }
    }
}
