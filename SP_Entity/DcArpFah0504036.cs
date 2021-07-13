using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504036
    {
        public DcArpFah0504036()
        {
            Fs0504036List = new HashSet<Fs0504036List>();
            FsOvApprovalList = new HashSet<FsOvApprovalList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PReportType { get; set; }
        public DateTime? PBeginGlDate { get; set; }
        public DateTime? PEndGlDate { get; set; }
        public string PRptDate { get; set; }
        public string PLedgerSetId { get; set; }
        public string PBudgetLevelCode { get; set; }
        public string PBudgetLevelCoden { get; set; }
        public string PBudgetTypeCode { get; set; }
        public string PBudgetCode { get; set; }
        public string PFundSource { get; set; }
        public string PAccount { get; set; }
        public string POfficeName { get; set; }
        public string PGrp1 { get; set; }
        public string PGrp2 { get; set; }
        public string PGrp3 { get; set; }
        public string PGrp4 { get; set; }
        public string PSumFlag { get; set; }
        public string PExecutor { get; set; }
        public string PUserId { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PFormatTxt { get; set; }
        public string PSubsistemKey { get; set; }
        public string PProgram { get; set; }
        public string PResponsibilityKey { get; set; }
        public string PRespAapplicationShortName { get; set; }
        public string PUserName { get; set; }
        public string StatusName { get; set; }
        public string PhaseName { get; set; }
        public string CompletionText { get; set; }
        public string PReportform { get; set; }
        public string PReportformCode { get; set; }
        public string PTofkOpenCode { get; set; }
        public DateTime? PReportDate { get; set; }
        public string PDistrPayments { get; set; }
        public string PSegm10 { get; set; }
        public string PLedgerSet { get; set; }
        public string PLedger { get; set; }
        public string PVsFundSource { get; set; }
        public string PTofkCode { get; set; }
        public string PLedgerId { get; set; }
        public string PVsSegment4 { get; set; }
        public string PManagerPosition { get; set; }
        public string PManagerName { get; set; }
        public string PExecutorName { get; set; }
        public string PExecutorPosition { get; set; }
        public string PManagerRole { get; set; }
        public string PExecutorRole { get; set; }
        public string POebsLink { get; set; }
        public string PXmlFormat { get; set; }
        public DateTime? BeginGlDate { get; set; }
        public DateTime? EndGlDate { get; set; }
        public string HRAccType { get; set; }
        public string HRBdgName { get; set; }
        public string RHFundSource { get; set; }
        public string HRReportDate { get; set; }
        public DateTime? HRDate { get; set; }
        public string HROfkName { get; set; }
        public string HROfk { get; set; }
        public string HRAcc { get; set; }
        public string HRDeptName { get; set; }
        public string PAccMain { get; set; }
        public string PAlwaysPrintFlag { get; set; }
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
        public DateTime? HRBeginDate { get; set; }
        public DateTime? HREndDate { get; set; }
        public decimal? DStart { get; set; }
        public decimal? CStart { get; set; }
        public decimal? DTurnover { get; set; }
        public decimal? CTurnover { get; set; }
        public decimal? DEnd { get; set; }
        public decimal? CEnd { get; set; }
        public string Okpo { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string InstCopy { get; set; }
        public string Ledgerset { get; set; }
        public string Inst { get; set; }
        public string Format { get; set; }
        public string ExecRes { get; set; }
        public string ManagRes { get; set; }
        public bool? PSumFlagB { get; set; }
        public bool? PAlwaysPrintFlagB { get; set; }
        public string PUfosGuid { get; set; }

        public virtual ICollection<Fs0504036List> Fs0504036List { get; set; }
        public virtual ICollection<FsOvApprovalList> FsOvApprovalList { get; set; }
    }
}
