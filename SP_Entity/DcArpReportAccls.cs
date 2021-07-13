using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReportAccls
    {
        public DcArpReportAccls()
        {
            FsLinkdocacclsList = new HashSet<FsLinkdocacclsList>();
            FsRepAccAgreerList = new HashSet<FsRepAccAgreerList>();
            FsRepAccApproveList = new HashSet<FsRepAccApproveList>();
            FsRepAccExecutorList = new HashSet<FsRepAccExecutorList>();
            FsRpRequestList = new HashSet<FsRpRequestList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string RtFormname { get; set; }
        public string RtFormcode { get; set; }
        public DateTime? RtReportdate { get; set; }
        public DateTime? RtReportdateOld { get; set; }
        public string RtAccountnum { get; set; }
        public string RtTypels { get; set; }
        public string RtOrfkCode { get; set; }
        public string RtOrfkName { get; set; }
        public string RtBudgetCode { get; set; }
        public string RtBudgetName { get; set; }
        public string SvrCodeGlava { get; set; }
        public string RtCoderegis { get; set; }
        public string RtFullname { get; set; }
        public string AoCreateifempty { get; set; }
        public string PAoCreateifempty { get; set; }
        public string AoShowlnzero { get; set; }
        public string PAoShowlnzero { get; set; }
        public string AddRpDocs { get; set; }
        public string PAddRpDocs { get; set; }
        public string FormatRtf { get; set; }
        public string FormatTxt { get; set; }
        public string FormatPdf { get; set; }
        public string FormatExl { get; set; }
        public string XmlFormat { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public string AoPosition { get; set; }
        public string AoFullname { get; set; }
        public string AoTelephone { get; set; }
        public string AoExecuser { get; set; }
        public string ReportType { get; set; }
        public string ReportTypeFlag { get; set; }
        public string PhaseName { get; set; }
        public string StatusName { get; set; }
        public string CompletionText { get; set; }
        public string PUserName { get; set; }
        public string PResponsibilityKey { get; set; }
        public string PRespAapplicationShortName { get; set; }
        public string PArgument5 { get; set; }
        public string PSubsistemKey { get; set; }
        public string Zero { get; set; }
        public string Guid { get; set; }
        public string Program { get; set; }
        public string OrgGuid { get; set; }
        public string OrgUbpNumber { get; set; }
        public string OrgUbpBudget { get; set; }
        public string PEmpty { get; set; }
        public DateTime? Dataform { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }
        public string LaAgreerSfp { get; set; }
        public string LaAgreerPost { get; set; }
        public DateTime? LaAgreerDate { get; set; }
        public string LaApproverSfp { get; set; }
        public string LaApproverPost { get; set; }
        public DateTime? LaApproverDate { get; set; }
        public string LaListAppGuid { get; set; }
        public string LaFlagautosign { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiLampgroupjms { get; set; }
        public string SiStateJms { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public string SiCirctechsign { get; set; }
        public string SiGrbssysname { get; set; }
        public string SiTofkSysname { get; set; }
        public string SiCommentText { get; set; }
        public string ParentGuid { get; set; }
        public string Secrecylevel { get; set; }

        public virtual ICollection<FsLinkdocacclsList> FsLinkdocacclsList { get; set; }
        public virtual ICollection<FsRepAccAgreerList> FsRepAccAgreerList { get; set; }
        public virtual ICollection<FsRepAccApproveList> FsRepAccApproveList { get; set; }
        public virtual ICollection<FsRepAccExecutorList> FsRepAccExecutorList { get; set; }
        public virtual ICollection<FsRpRequestList> FsRpRequestList { get; set; }
    }
}
