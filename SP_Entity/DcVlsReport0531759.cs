using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcVlsReport0531759
    {
        public DcVlsReport0531759()
        {
            FsPuioVls2List = new HashSet<FsPuioVls2List>();
            FsPuioVlsList = new HashSet<FsPuioVlsList>();
            FsR759GS11DList = new HashSet<FsR759GS11DList>();
            FsR759GS121DList = new HashSet<FsR759GS121DList>();
            FsR759GS122DList = new HashSet<FsR759GS122DList>();
            FsR759GS123DList = new HashSet<FsR759GS123DList>();
            FsR759GS131DList = new HashSet<FsR759GS131DList>();
            FsR759GS132DList = new HashSet<FsR759GS132DList>();
            FsR759GS21DList = new HashSet<FsR759GS21DList>();
            FsR759GS22DList = new HashSet<FsR759GS22DList>();
            FsR759GS23DList = new HashSet<FsR759GS23DList>();
            FsR759GS24DList = new HashSet<FsR759GS24DList>();
            FsR759GS25DList = new HashSet<FsR759GS25DList>();
            FsR759GS26DList = new HashSet<FsR759GS26DList>();
            FsR759GS27DList = new HashSet<FsR759GS27DList>();
            FsR759GS28DList = new HashSet<FsR759GS28DList>();
            FsR759GS29DList = new HashSet<FsR759GS29DList>();
            FsR759GS31DList = new HashSet<FsR759GS31DList>();
            FsR759GS32DList = new HashSet<FsR759GS32DList>();
            FsR759GS33DList = new HashSet<FsR759GS33DList>();
            FsR759GS34DList = new HashSet<FsR759GS34DList>();
            FsR759GS41DList = new HashSet<FsR759GS41DList>();
            FsR759GS42DList = new HashSet<FsR759GS42DList>();
            FsRGS23GrfList = new HashSet<FsRGS23GrfList>();
            FsRGS25GrfList = new HashSet<FsRGS25GrfList>();
            FsRGS26GrfList = new HashSet<FsRGS26GrfList>();
            FsRGS27GrfList = new HashSet<FsRGS27GrfList>();
            FsRGS27OList = new HashSet<FsRGS27OList>();
            FsRGS28GrfList = new HashSet<FsRGS28GrfList>();
            FsRGS29GrfList = new HashSet<FsRGS29GrfList>();
            FsRGS29OList = new HashSet<FsRGS29OList>();
            FsVlsAgrList = new HashSet<FsVlsAgrList>();
            FsVlsAppList = new HashSet<FsVlsAppList>();
            FsVlsAppaccList = new HashSet<FsVlsAppaccList>();
            FsVlsAppfesList = new HashSet<FsVlsAppfesList>();
            FsVlsExrList = new HashSet<FsVlsExrList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfRtFormname { get; set; }
        public string InfRtFormcode { get; set; }
        public DateTime? InfDocdate { get; set; }
        public DateTime? InfPreviousdate { get; set; }
        public DateTime? InfDocdateold { get; set; }
        public string InfRtAccountnum { get; set; }
        public string InfReportTypeFlag { get; set; }
        public string InfAddRpDocs { get; set; }
        public string InfCreateifempty { get; set; }
        public string InfShowlnzero { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public string InfUbpCode { get; set; }
        public string InfUbpName { get; set; }
        public string InfUbpRecCode { get; set; }
        public string InfUbpRecName { get; set; }
        public string InfUbpRecCodeRubp { get; set; }
        public string InfGrbsCode { get; set; }
        public string InfGrbsUbpcode { get; set; }
        public string InfGrbsName { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfFoFinancialinst { get; set; }
        public string InfFoOkpocode { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string OktCode { get; set; }
        public string OktName { get; set; }
        public string InfReportPeriodFlag { get; set; }
        public string InfDocnumber { get; set; }
        public string InfRbsCode { get; set; }
        public string InfRbsName { get; set; }
        public DateTime? InfDocdateStart { get; set; }
        public string InfRtTypels { get; set; }
        public string InfRbsCodeRubp { get; set; }
        public string InfUbpCodeRubp { get; set; }
        public string InfSource { get; set; }
        public string InfDoctype { get; set; }
        public DateTime? InfDocdateNext { get; set; }
        public string InfProgram { get; set; }
        public string InfOrgUbpNumber { get; set; }
        public string InfOrgGlavaCode { get; set; }
        public string InfOrgUbpBudget { get; set; }
        public string InfGrbssysname { get; set; }
        public string InfTofkSysname { get; set; }
        public string InfCommentText { get; set; }
        public string InfParentGuid { get; set; }
        public string InfOpentofkSvr { get; set; }
        public string InfOpentofkName { get; set; }
        public string InfOpentofkCode { get; set; }
        public string InfRctofkName { get; set; }
        public string InfRctofkCode { get; set; }
        public string InfUchettofkCode { get; set; }
        public string InfLastGuid { get; set; }
        public bool? InfShownulltabs { get; set; }
        public string InfCreateReport { get; set; }
        public string InfCreateReportGuid { get; set; }
        public decimal? RGS121FR4 { get; set; }
        public decimal? RGS121FR5 { get; set; }
        public decimal? RGS121FR6 { get; set; }
        public decimal? RGS121FR7 { get; set; }
        public decimal? RGS121FR8 { get; set; }
        public decimal? RGS121FR9 { get; set; }
        public decimal? RGS121FR10 { get; set; }
        public decimal? RGS121FR11 { get; set; }
        public string RGS121FRcount { get; set; }
        public decimal? RGS122FR4 { get; set; }
        public decimal? RGS122FR5 { get; set; }
        public string RGS122FRcount { get; set; }
        public decimal? RGS123FR3 { get; set; }
        public string RGS123FRcount { get; set; }
        public decimal? RGS131FR4 { get; set; }
        public decimal? RGS131FR5 { get; set; }
        public decimal? RGS131FR6 { get; set; }
        public string RGS131FRcount { get; set; }
        public decimal? RGS132FR4 { get; set; }
        public decimal? RGS132FR5 { get; set; }
        public string RGS132FRcount { get; set; }
        public decimal? RGS22FR5 { get; set; }
        public string RGS22FRcount { get; set; }
        public decimal? RGS23FR7 { get; set; }
        public string RGS23FRcount { get; set; }
        public decimal? RGS24FR7 { get; set; }
        public string RGS24FRcount { get; set; }
        public decimal? RGS25FR9 { get; set; }
        public string RGS25FRcount { get; set; }
        public decimal? RGS26FR5 { get; set; }
        public decimal? RGS26FR6 { get; set; }
        public decimal? RGS26FR7 { get; set; }
        public string RGS26FRcount { get; set; }
        public decimal? RGS27FR8 { get; set; }
        public decimal? RGS27FR9 { get; set; }
        public decimal? RGS27FR10 { get; set; }
        public string RGS27FRcount { get; set; }
        public decimal? RGS28FR5 { get; set; }
        public string RGS28FRcount { get; set; }
        public decimal? RGS29FR8 { get; set; }
        public string RGS29FRcount { get; set; }
        public decimal? RGS32FR3 { get; set; }
        public decimal? RGS32FR4 { get; set; }
        public decimal? RGS32FR6 { get; set; }
        public decimal? RGS32FR8 { get; set; }
        public string RGS32FRcount { get; set; }
        public decimal? RGS33FR5 { get; set; }
        public decimal? RGS33FR6 { get; set; }
        public string RGS33FRcount { get; set; }
        public decimal? RGS34FR5 { get; set; }
        public decimal? RGS34FR6 { get; set; }
        public string RGS34FRcount { get; set; }
        public decimal? RGS42FR5 { get; set; }
        public decimal? RGS42FR6 { get; set; }
        public decimal? RGS42FR7 { get; set; }
        public string RGS42FRcount { get; set; }
        public decimal? RBdSum { get; set; }
        public decimal? RBdAmount { get; set; }
        public decimal? RBhSum { get; set; }
        public decimal? RBhAmount { get; set; }
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
        public string SiLampgroupLk { get; set; }
        public string SiCirctechsign { get; set; }
        public string SiLampgroupregtn { get; set; }
        public string SiLampgroupchkr { get; set; }
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
        public bool? VlsSkipappr { get; set; }
        public decimal? VlsAmountrowexe { get; set; }
        public decimal? VlsAmountrowagr { get; set; }
        public decimal? VlsAmountrowapp { get; set; }
        public decimal? VlsAmountrowappacc { get; set; }
        public decimal? VlsAmountrowappfes { get; set; }
        public string VlsLoginlistexecutor { get; set; }
        public string VlsLoginlistagreer { get; set; }
        public string VlsLoginlistapprover { get; set; }
        public string VlsLoginlistappacc { get; set; }
        public string VlsLoginlistappfes { get; set; }
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
        public string VlsApprovalstep { get; set; }

        public virtual ICollection<FsPuioVls2List> FsPuioVls2List { get; set; }
        public virtual ICollection<FsPuioVlsList> FsPuioVlsList { get; set; }
        public virtual ICollection<FsR759GS11DList> FsR759GS11DList { get; set; }
        public virtual ICollection<FsR759GS121DList> FsR759GS121DList { get; set; }
        public virtual ICollection<FsR759GS122DList> FsR759GS122DList { get; set; }
        public virtual ICollection<FsR759GS123DList> FsR759GS123DList { get; set; }
        public virtual ICollection<FsR759GS131DList> FsR759GS131DList { get; set; }
        public virtual ICollection<FsR759GS132DList> FsR759GS132DList { get; set; }
        public virtual ICollection<FsR759GS21DList> FsR759GS21DList { get; set; }
        public virtual ICollection<FsR759GS22DList> FsR759GS22DList { get; set; }
        public virtual ICollection<FsR759GS23DList> FsR759GS23DList { get; set; }
        public virtual ICollection<FsR759GS24DList> FsR759GS24DList { get; set; }
        public virtual ICollection<FsR759GS25DList> FsR759GS25DList { get; set; }
        public virtual ICollection<FsR759GS26DList> FsR759GS26DList { get; set; }
        public virtual ICollection<FsR759GS27DList> FsR759GS27DList { get; set; }
        public virtual ICollection<FsR759GS28DList> FsR759GS28DList { get; set; }
        public virtual ICollection<FsR759GS29DList> FsR759GS29DList { get; set; }
        public virtual ICollection<FsR759GS31DList> FsR759GS31DList { get; set; }
        public virtual ICollection<FsR759GS32DList> FsR759GS32DList { get; set; }
        public virtual ICollection<FsR759GS33DList> FsR759GS33DList { get; set; }
        public virtual ICollection<FsR759GS34DList> FsR759GS34DList { get; set; }
        public virtual ICollection<FsR759GS41DList> FsR759GS41DList { get; set; }
        public virtual ICollection<FsR759GS42DList> FsR759GS42DList { get; set; }
        public virtual ICollection<FsRGS23GrfList> FsRGS23GrfList { get; set; }
        public virtual ICollection<FsRGS25GrfList> FsRGS25GrfList { get; set; }
        public virtual ICollection<FsRGS26GrfList> FsRGS26GrfList { get; set; }
        public virtual ICollection<FsRGS27GrfList> FsRGS27GrfList { get; set; }
        public virtual ICollection<FsRGS27OList> FsRGS27OList { get; set; }
        public virtual ICollection<FsRGS28GrfList> FsRGS28GrfList { get; set; }
        public virtual ICollection<FsRGS29GrfList> FsRGS29GrfList { get; set; }
        public virtual ICollection<FsRGS29OList> FsRGS29OList { get; set; }
        public virtual ICollection<FsVlsAgrList> FsVlsAgrList { get; set; }
        public virtual ICollection<FsVlsAppList> FsVlsAppList { get; set; }
        public virtual ICollection<FsVlsAppaccList> FsVlsAppaccList { get; set; }
        public virtual ICollection<FsVlsAppfesList> FsVlsAppfesList { get; set; }
        public virtual ICollection<FsVlsExrList> FsVlsExrList { get; set; }
    }
}
