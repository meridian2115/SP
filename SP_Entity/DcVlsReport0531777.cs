using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcVlsReport0531777
    {
        public DcVlsReport0531777()
        {
            FsR777GS12DList = new HashSet<FsR777GS12DList>();
            FsR777GS1DList = new HashSet<FsR777GS1DList>();
            FsR777GS212DList = new HashSet<FsR777GS212DList>();
            FsR777GS21DList = new HashSet<FsR777GS21DList>();
            FsR777GS22DList = new HashSet<FsR777GS22DList>();
            FsR777GS23DList = new HashSet<FsR777GS23DList>();
            FsR777GS31DList = new HashSet<FsR777GS31DList>();
            FsR777GS32DList = new HashSet<FsR777GS32DList>();
            FsR777GS33DList = new HashSet<FsR777GS33DList>();
            FsR777GS34DList = new HashSet<FsR777GS34DList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDocdate { get; set; }
        public DateTime? InfDocdateStart { get; set; }
        public string InfRtFormcode { get; set; }
        public string InfRtFormname { get; set; }
        public string InfRtAccountnum { get; set; }
        public string InfRtTypels { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public string InfGrbsCode { get; set; }
        public string InfGrbsUbpcode { get; set; }
        public string InfGrbsName { get; set; }
        public string InfRbsCode { get; set; }
        public string InfRbsName { get; set; }
        public string InfRbsCodeRubp { get; set; }
        public string InfUbpCode { get; set; }
        public string InfUbpName { get; set; }
        public string InfUbpCodeRubp { get; set; }
        public string InfUbpRecCode { get; set; }
        public string InfUbpRecName { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfFoFinancialinst { get; set; }
        public string InfFoOkpocode { get; set; }
        public string OktCode { get; set; }
        public string OktName { get; set; }
        public string InfDoctype { get; set; }
        public DateTime? InfDocdateold { get; set; }
        public DateTime? InfDocdateNext { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfCreateifempty { get; set; }
        public string InfProgram { get; set; }
        public string InfAddRpDocs { get; set; }
        public string InfReportPeriodFlag { get; set; }
        public string InfReportTypeFlag { get; set; }
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
        public DateTime? InfFirstday { get; set; }
        public DateTime? InfDocdatePrev { get; set; }
        public string InfSecrecy { get; set; }
        public string InfGuid0531758 { get; set; }
        public string InfReportTypeEnum { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public string SiLampgroupftas { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiLampgrouptn { get; set; }
        public string SiCirctechsign { get; set; }
        public string SiLampgroupregtn { get; set; }
        public string SiLampgroupchkr { get; set; }
        public string SiProtocolGuid { get; set; }
        public string SiCheckpuioresult { get; set; }
        public string SiErrormessage { get; set; }
        public string SiErrorstack { get; set; }
        public string SiGrbssysname { get; set; }
        public string SiTofkSysname { get; set; }
        public string SiCommentText { get; set; }
        public string SiStateJms { get; set; }
        public string SiLampgroupjms { get; set; }
        public string SiTofkName { get; set; }
        public string SiTofkCode { get; set; }
        public string SiStfkName { get; set; }
        public string SiStfkCode { get; set; }
        public string VlsExecutorSfp { get; set; }
        public string VlsExecutorPost { get; set; }
        public string VlsExecutorTel { get; set; }
        public decimal? RGS1FR2 { get; set; }
        public decimal? RGS1FR3 { get; set; }
        public decimal? RGS1FR4 { get; set; }
        public decimal? RGS1FR5 { get; set; }
        public decimal? RGS1FR6 { get; set; }
        public decimal? RGS1FR7 { get; set; }
        public decimal? RGS1FR8 { get; set; }
        public decimal? RGS1FR9 { get; set; }
        public decimal? RGS1FR10 { get; set; }
        public decimal? RGS21FR3 { get; set; }
        public decimal? RGS21FR4 { get; set; }
        public decimal? RGS21FR5 { get; set; }
        public decimal? RGS21FR6 { get; set; }
        public decimal? RGS21FR7 { get; set; }
        public decimal? RGS21FR8 { get; set; }
        public decimal? RGS21FR9 { get; set; }
        public decimal? RGS21FR10 { get; set; }
        public decimal? RGS21FR11 { get; set; }
        public decimal? RGS22FR3 { get; set; }
        public decimal? RGS22FR4 { get; set; }
        public decimal? RGS22FR5 { get; set; }
        public decimal? RGS23FR3 { get; set; }
        public decimal? RGS23FR4 { get; set; }
        public decimal? RGS23FR5 { get; set; }
        public decimal? RGS31FR2 { get; set; }
        public decimal? RGS31FR3 { get; set; }
        public decimal? RGS31FR4 { get; set; }
        public decimal? RGS32FR2 { get; set; }
        public decimal? RGS32FR3 { get; set; }
        public decimal? RGS32FR4 { get; set; }
        public decimal? RGS33FR2 { get; set; }
        public decimal? RGS33FR3 { get; set; }
        public decimal? RGS33FR4 { get; set; }
        public decimal? RGS34FR2 { get; set; }
        public decimal? RGS34FR3 { get; set; }
        public decimal? RGS34FR4 { get; set; }
        public string HFy { get; set; }
        public string HFyAdd1 { get; set; }
        public string HFyAdd2 { get; set; }
        public string HFyAdd3 { get; set; }
        public string SiGuidpur { get; set; }
        public DateTime? SiDateform { get; set; }
        public string SiTfDocstate { get; set; }
        public decimal? RGS1FR11 { get; set; }
        public decimal? RGS1FR12 { get; set; }
        public decimal? RGS1FR13 { get; set; }
        public decimal? RGS1FR14 { get; set; }
        public decimal? RGS1FR15 { get; set; }
        public decimal? RGS1FR16 { get; set; }
        public decimal? RGS21FR12 { get; set; }
        public decimal? RGS21FR13 { get; set; }
        public decimal? RGS21FR14 { get; set; }
        public decimal? RGS21FR15 { get; set; }
        public decimal? RGS21FR16 { get; set; }
        public decimal? RGS21FR17 { get; set; }
        public DateTime? VlsExecutorDate { get; set; }

        public virtual ICollection<FsR777GS12DList> FsR777GS12DList { get; set; }
        public virtual ICollection<FsR777GS1DList> FsR777GS1DList { get; set; }
        public virtual ICollection<FsR777GS212DList> FsR777GS212DList { get; set; }
        public virtual ICollection<FsR777GS21DList> FsR777GS21DList { get; set; }
        public virtual ICollection<FsR777GS22DList> FsR777GS22DList { get; set; }
        public virtual ICollection<FsR777GS23DList> FsR777GS23DList { get; set; }
        public virtual ICollection<FsR777GS31DList> FsR777GS31DList { get; set; }
        public virtual ICollection<FsR777GS32DList> FsR777GS32DList { get; set; }
        public virtual ICollection<FsR777GS33DList> FsR777GS33DList { get; set; }
        public virtual ICollection<FsR777GS34DList> FsR777GS34DList { get; set; }
    }
}
