using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcExpInfbo
    {
        public DcExpInfbo()
        {
            FsAgiTehDecAgreerList = new HashSet<FsAgiTehDecAgreerList>();
            FsApAtList = new HashSet<FsApAtList>();
            FsApEtList = new HashSet<FsApEtList>();
            FsBoAgreerList = new HashSet<FsBoAgreerList>();
            FsOsPaymnList = new HashSet<FsOsPaymnList>();
            FsOsResList = new HashSet<FsOsResList>();
            FsRtTablsubsidList = new HashSet<FsRtTablsubsidList>();
            FsSiTabsiList = new HashSet<FsSiTabsiList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfNumberdocument { get; set; }
        public DateTime? InfDatedocument { get; set; }
        public string InfTypedocument { get; set; }
        public string InfNumberchange { get; set; }
        public string ApriGuid { get; set; }
        public DateTime? ApriCreationdate { get; set; }
        public string InfSource { get; set; }
        public string InfNotecancel { get; set; }
        public string InfTypedoc { get; set; }
        public string InfPackguid { get; set; }
        public string InfRoutesbosgk { get; set; }
        public string RbNamerecip { get; set; }
        public string RbCodegrbs { get; set; }
        public string RbCodeokpo { get; set; }
        public string RbNumberaccount { get; set; }
        public string RbGlavabkcode { get; set; }
        public string RbGrbs { get; set; }
        public string RbNamebudget { get; set; }
        public string RbCodeoktmo { get; set; }
        public string RbNamefinorg { get; set; }
        public string RbCodetofk { get; set; }
        public string RbNametofk { get; set; }
        public string RbUniccodeorg { get; set; }
        public string RbCodeokpofin { get; set; }
        public string RbCodebudjet { get; set; }
        public string IdbTypedocbase { get; set; }
        public string IdbNamedocbase { get; set; }
        public string IdbRoomact { get; set; }
        public DateTime? IdbDatecontract { get; set; }
        public string IdbSubjectdocbase { get; set; }
        public string IdbRegisnmbrbo { get; set; }
        public string IdbRegisnmbrg { get; set; }
        public decimal? IdbSumsubsid { get; set; }
        public string IdbCodecurren { get; set; }
        public decimal? IdbSumsubsrub { get; set; }
        public decimal? IdbAdvancepay { get; set; }
        public decimal? IdbAmountadvpay { get; set; }
        public string IdbNotificnmbr { get; set; }
        public DateTime? IdbNotificdt { get; set; }
        public string IdbCnsdcntrct { get; set; }
        public decimal? IdbCourseTech { get; set; }
        public string IdbTypedocbasepur { get; set; }
        public string IdbTypedocbasesecret { get; set; }
        public decimal? IdbSumsubsidTech { get; set; }
        public string MfkNumberbo { get; set; }
        public DateTime? MfkDateregis { get; set; }
        public string MfkNmbrrgsentr { get; set; }
        public DateTime? MfkDatels { get; set; }
        public string MfkSignasfk { get; set; }
        public string MfkGuidProtokol { get; set; }
        public string MfkGuidnotice { get; set; }
        public string MfkGuidexpBo { get; set; }
        public string MfkNamerespons { get; set; }
        public string MfkPostrespons { get; set; }
        public DateTime? MfkDatesigning { get; set; }
        public string MfkTelephone { get; set; }
        public string MfkOrgmakingcontrol { get; set; }
        public string MfkCoderegis { get; set; }
        public string MfkGuiddec { get; set; }
        public string MfkReflectionaccount { get; set; }
        public string SgNamehead { get; set; }
        public string SgPosthead { get; set; }
        public DateTime? SgDatesigning { get; set; }
        public string SgNamerespon { get; set; }
        public string SgPostrespon { get; set; }
        public DateTime? SgDatesigcharge { get; set; }
        public string LaNameexec { get; set; }
        public string LaPostexec { get; set; }
        public DateTime? LaDatesignexec { get; set; }
        public string LaNameheadutv { get; set; }
        public string LaPostheadutv { get; set; }
        public DateTime? LaDatesignutv { get; set; }
        public string LaApproverDsc { get; set; }
        public string LaNote { get; set; }
        public string SiRegisterinformaccguid { get; set; }
        public string SiRowidcode { get; set; }
        public string SiHeadidcode { get; set; }
        public string SiResultparam { get; set; }
        public string SiTextresultparam { get; set; }
        public string SiAccountnum { get; set; }
        public DateTime? SiExecutiondate { get; set; }
        public string SiRejectionreason { get; set; }
        public string SiRelevancesign { get; set; }
        public string SiGuidPur { get; set; }
        public string SiLoginuser { get; set; }
        public string SiExtrafield1 { get; set; }
        public string SiExtrafield3 { get; set; }
        public string SiUserflag1 { get; set; }
        public string SiUserflag2 { get; set; }
        public bool? SiAgreerSkipall { get; set; }
        public string SiAgreerCommondsc { get; set; }
        public string SiTempCommonnote { get; set; }
        public string SiApproverDepartment { get; set; }
        public string SiApproverDsc { get; set; }
        public DateTime? SiApproverStartdate { get; set; }
        public string SiKbktypemap { get; set; }
        public string SiGuidSs { get; set; }
        public string SiFonarincludpbo { get; set; }
        public string SiTehfield1 { get; set; }
        public string SiShowtabfaip { get; set; }
        public string CodeCompositeReg { get; set; }
        public string Login { get; set; }
        public bool? AgiSkipappr { get; set; }
        public string AgiApprfio { get; set; }
        public string AgiApppost { get; set; }
        public DateTime? AgiDatesend { get; set; }
        public DateTime? AgiDateappr { get; set; }
        public string AgiNotings { get; set; }
        public string AgiLogin { get; set; }
        public string AgiApproverDsc { get; set; }
        public string AgiAgreerCommondsc { get; set; }
        public string AgiTempCommonnote { get; set; }
        public string AgiApproverDepartment { get; set; }
        public string AgiUserflagdec { get; set; }
        public string AgiCheckres { get; set; }
        public string AgiExfio { get; set; }
        public string AgiExpost { get; set; }
        public string AgiExlogin { get; set; }
        public string AgiApprdecinsbo { get; set; }
        public DateTime? AgiDecrcdt { get; set; }
        public string CtrGuidforcounter { get; set; }
        public string CtrInfconstnum { get; set; }
        public string CtrUserflag4 { get; set; }
        public string Assnmbrconst { get; set; }
        public string Guidparentdoc { get; set; }
        public string GuidexpAss { get; set; }
        public string GuidexpBoPr { get; set; }
        public string Csdoctype { get; set; }
        public string Techorgid { get; set; }
        public string ApRbGrbs1 { get; set; }
        public string ApRbGrbs2 { get; set; }
        public string ApRbGrbs3 { get; set; }
        public string EventTypeCode { get; set; }
        public string ReversalIndicator { get; set; }
        public string DocGroup { get; set; }
        public string DocType { get; set; }
        public string BusinessStatus { get; set; }
        public string ApprovalStatus { get; set; }
        public string TransferStatus { get; set; }
        public string DocSource { get; set; }
        public string SourceTable { get; set; }
        public DateTime? SourceId { get; set; }
        public string YForDateregis { get; set; }

        public virtual ICollection<FsAgiTehDecAgreerList> FsAgiTehDecAgreerList { get; set; }
        public virtual ICollection<FsApAtList> FsApAtList { get; set; }
        public virtual ICollection<FsApEtList> FsApEtList { get; set; }
        public virtual ICollection<FsBoAgreerList> FsBoAgreerList { get; set; }
        public virtual ICollection<FsOsPaymnList> FsOsPaymnList { get; set; }
        public virtual ICollection<FsOsResList> FsOsResList { get; set; }
        public virtual ICollection<FsRtTablsubsidList> FsRtTablsubsidList { get; set; }
        public virtual ICollection<FsSiTabsiList> FsSiTabsiList { get; set; }
    }
}
