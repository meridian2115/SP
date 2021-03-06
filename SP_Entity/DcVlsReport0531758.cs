using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcVlsReport0531758
    {
        public DcVlsReport0531758()
        {
            FsR758GS11DList = new HashSet<FsR758GS11DList>();
            FsR758GS21DList = new HashSet<FsR758GS21DList>();
            FsR758GS22DList = new HashSet<FsR758GS22DList>();
            FsR758GS23DList = new HashSet<FsR758GS23DList>();
            FsR758GS31DList = new HashSet<FsR758GS31DList>();
            FsR758GS32DList = new HashSet<FsR758GS32DList>();
            FsR758GS33DList = new HashSet<FsR758GS33DList>();
            FsR758GS41DList = new HashSet<FsR758GS41DList>();
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
        public string InfCreateReport { get; set; }
        public string InfCreateReportGuid { get; set; }
        public DateTime? InfDocdatePrev { get; set; }
        public string InfSecrecy { get; set; }
        public string InfReportTypeEnum { get; set; }
        public decimal? RGS21FR5 { get; set; }
        public decimal? RGS21FR6 { get; set; }
        public decimal? RGS21FR7 { get; set; }
        public decimal? RGS21FR8 { get; set; }
        public decimal? RGS21FR9 { get; set; }
        public decimal? RGS21FR10 { get; set; }
        public decimal? RGS21FR11 { get; set; }
        public decimal? RGS22FR5 { get; set; }
        public decimal? RGS22FR6 { get; set; }
        public decimal? RGS23FR4 { get; set; }
        public decimal? RGS23FR5 { get; set; }
        public decimal? RGS31FR5 { get; set; }
        public decimal? RGS31FR6 { get; set; }
        public decimal? RGS31FR7 { get; set; }
        public decimal? RGS31FR8 { get; set; }
        public decimal? RGS31FR9 { get; set; }
        public decimal? RGS31FR10 { get; set; }
        public decimal? RGS31FR11 { get; set; }
        public decimal? RGS32FR5 { get; set; }
        public decimal? RGS32FR6 { get; set; }
        public decimal? RGS33FR4 { get; set; }
        public decimal? RGS33FR5 { get; set; }
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
        public string SiCirctechsign { get; set; }
        public string SiProtocolGuid { get; set; }
        public string SiErrormessage { get; set; }
        public string SiErrorstack { get; set; }
        public string SiGrbssysname { get; set; }
        public string SiTofkSysname { get; set; }
        public string SiStateJms { get; set; }
        public string SiTofkName { get; set; }
        public string SiTofkCode { get; set; }
        public string SiStfkName { get; set; }
        public string SiStfkCode { get; set; }
        public string VlsExecutorSfp { get; set; }
        public string VlsExecutorPost { get; set; }
        public string VlsExecutorTel { get; set; }
        public string SiGuidpur { get; set; }
        public DateTime? SiDateform { get; set; }
        public decimal? RGS11FR2B { get; set; }
        public decimal? RGS11FR3B { get; set; }
        public decimal? RGS11FR4B { get; set; }
        public decimal? RGS11FR5B { get; set; }
        public decimal? RGS11FR6B { get; set; }
        public decimal? RGS11FR7B { get; set; }
        public decimal? RGS11FR8B { get; set; }
        public decimal? RGS11FR9B { get; set; }
        public decimal? RGS11FR2E { get; set; }
        public decimal? RGS11FR3E { get; set; }
        public decimal? RGS11FR4E { get; set; }
        public decimal? RGS11FR5E { get; set; }
        public decimal? RGS11FR6E { get; set; }
        public decimal? RGS11FR7E { get; set; }
        public decimal? RGS11FR8E { get; set; }
        public decimal? RGS11FR9E { get; set; }
        public string SiTfDocstate { get; set; }
        public decimal? RGS41FR5 { get; set; }
        public decimal? RGS41FR6 { get; set; }
        public decimal? RGS41FR7 { get; set; }
        public decimal? RGS41FR8 { get; set; }
        public decimal? RGS41FR9 { get; set; }
        public decimal? RGS41FR10 { get; set; }
        public DateTime? VlsExecutorDate { get; set; }

        public virtual ICollection<FsR758GS11DList> FsR758GS11DList { get; set; }
        public virtual ICollection<FsR758GS21DList> FsR758GS21DList { get; set; }
        public virtual ICollection<FsR758GS22DList> FsR758GS22DList { get; set; }
        public virtual ICollection<FsR758GS23DList> FsR758GS23DList { get; set; }
        public virtual ICollection<FsR758GS31DList> FsR758GS31DList { get; set; }
        public virtual ICollection<FsR758GS32DList> FsR758GS32DList { get; set; }
        public virtual ICollection<FsR758GS33DList> FsR758GS33DList { get; set; }
        public virtual ICollection<FsR758GS41DList> FsR758GS41DList { get; set; }
    }
}
