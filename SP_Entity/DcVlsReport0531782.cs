using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcVlsReport0531782
    {
        public DcVlsReport0531782()
        {
            FsPuioVls2782List = new HashSet<FsPuioVls2782List>();
            FsPuioVls782List = new HashSet<FsPuioVls782List>();
            FsR782GS11DList = new HashSet<FsR782GS11DList>();
            FsR782GS12DList = new HashSet<FsR782GS12DList>();
            FsR782GS2DList = new HashSet<FsR782GS2DList>();
            FsVlsAgr782List = new HashSet<FsVlsAgr782List>();
            FsVlsApp782List = new HashSet<FsVlsApp782List>();
            FsVlsAppacc782List = new HashSet<FsVlsAppacc782List>();
            FsVlsAppfes782List = new HashSet<FsVlsAppfes782List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfRtFormname { get; set; }
        public string InfRtFormcode { get; set; }
        public DateTime? InfDocdate { get; set; }
        public string InfRtAccountnum { get; set; }
        public string InfReportTypeFlag { get; set; }
        public string InfCreateifempty { get; set; }
        public string InfShowlnzero { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public string InfUbpCode { get; set; }
        public string InfUbpName { get; set; }
        public string InfGrbsCode { get; set; }
        public string InfGrbsUbpcode { get; set; }
        public string InfGrbsName { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfFoFinancialinst { get; set; }
        public string InfFoOkpocode { get; set; }
        public string OktCode { get; set; }
        public string OktName { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfReportPeriodFlag { get; set; }
        public string InfDocnumber { get; set; }
        public string InfRbsCode { get; set; }
        public string InfRbsName { get; set; }
        public string InfRtTypels { get; set; }
        public DateTime? InfDocdateStart { get; set; }
        public string InfRbsCodeRubp { get; set; }
        public string InfUbpCodeRubp { get; set; }
        public string InfSource { get; set; }
        public string InfDoctype { get; set; }
        public DateTime? InfDocdateold { get; set; }
        public DateTime? InfDocdateNext { get; set; }
        public string InfProgram { get; set; }
        public string InfAddRpDocs { get; set; }
        public string InfOrgUbpNumber { get; set; }
        public string InfOrgGlavaCode { get; set; }
        public string InfOrgUbpBudget { get; set; }
        public string InfGrbssysname { get; set; }
        public string InfTofkSysname { get; set; }
        public string InfParentGuid { get; set; }
        public string InfOpentofkSvr { get; set; }
        public string InfOpentofkName { get; set; }
        public string InfOpentofkCode { get; set; }
        public string InfRctofkName { get; set; }
        public string InfRctofkCode { get; set; }
        public string InfUchettofkCode { get; set; }
        public string InfLastGuid { get; set; }
        public bool? InfShownulltabs { get; set; }
        public string InfGuid0531764 { get; set; }
        public string InfSecrecy { get; set; }
        public decimal? RGS11FR3 { get; set; }
        public decimal? RGS11FR4 { get; set; }
        public decimal? RGS11FR5 { get; set; }
        public decimal? RGS12FR3 { get; set; }
        public decimal? RGS2FR2 { get; set; }
        public decimal? RGS2FR3 { get; set; }
        public decimal? RGS2FR4 { get; set; }
        public string HFy { get; set; }
        public string HFyAdd1 { get; set; }
        public string HFyAdd2 { get; set; }
        public string HFyAdd3 { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public DateTime? SiDttmcrt { get; set; }
        public string SiCommentText { get; set; }
        public string SiLampgroupftas { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiLampgrouptn { get; set; }
        public string SiCirctechsign { get; set; }
        public string SiLampgroupregtn { get; set; }
        public string SiLampgroupchkr { get; set; }
        public string SiLampgroupLk { get; set; }
        public string SiProtocolGuid { get; set; }
        public string SiCheckpuioresult { get; set; }
        public string SiErrormessage { get; set; }
        public string SiErrorstack { get; set; }
        public string SiGrbssysname { get; set; }
        public string SiTofkSysname { get; set; }
        public string SiStateJms { get; set; }
        public string SiLampgroupjms { get; set; }
        public string SiSrtSerialnumber { get; set; }
        public DateTime? SiSrtStartdate { get; set; }
        public DateTime? SiSrtEnddate { get; set; }
        public DateTime? SiSrtSigndate { get; set; }
        public string SiSrtSignerfio { get; set; }
        public string SiTofkName { get; set; }
        public string SiTofkCode { get; set; }
        public string SiStfkName { get; set; }
        public string SiStfkCode { get; set; }
        public string RcRcount11 { get; set; }
        public string RcRcount12 { get; set; }
        public string RcRcount2 { get; set; }
        public bool? VlsSkipappr { get; set; }
        public decimal? VlsAmountrowexe { get; set; }
        public decimal? VlsAmountrowagr { get; set; }
        public decimal? VlsAmountrowapp { get; set; }
        public decimal? VlsAmountrowappacc { get; set; }
        public decimal? VlsAmountrowappfes { get; set; }
        public string VlsExecutorUser { get; set; }
        public string VlsExecutorSfp { get; set; }
        public string VlsExecutorPost { get; set; }
        public DateTime? VlsExecutorDate { get; set; }
        public string VlsExecutorTel { get; set; }
        public string VlsAgreerSfp { get; set; }
        public string VlsAgreerPost { get; set; }
        public DateTime? VlsAgreerDate { get; set; }
        public string VlsApproverSfp { get; set; }
        public string VlsApproverPost { get; set; }
        public DateTime? VlsApproverDate { get; set; }
        public string VlsListAppGuid { get; set; }
        public string VlsListAppGuidTx { get; set; }
        public string VlsFlagautosign { get; set; }
        public string VlsLoginlistexecutor { get; set; }
        public string VlsLoginlistagreer { get; set; }
        public string VlsLoginlistapprover { get; set; }
        public string VlsLoginlistappacc { get; set; }
        public string VlsLoginlistappfes { get; set; }
        public string VlsApprovalstep { get; set; }

        public virtual ICollection<FsPuioVls2782List> FsPuioVls2782List { get; set; }
        public virtual ICollection<FsPuioVls782List> FsPuioVls782List { get; set; }
        public virtual ICollection<FsR782GS11DList> FsR782GS11DList { get; set; }
        public virtual ICollection<FsR782GS12DList> FsR782GS12DList { get; set; }
        public virtual ICollection<FsR782GS2DList> FsR782GS2DList { get; set; }
        public virtual ICollection<FsVlsAgr782List> FsVlsAgr782List { get; set; }
        public virtual ICollection<FsVlsApp782List> FsVlsApp782List { get; set; }
        public virtual ICollection<FsVlsAppacc782List> FsVlsAppacc782List { get; set; }
        public virtual ICollection<FsVlsAppfes782List> FsVlsAppfes782List { get; set; }
    }
}
