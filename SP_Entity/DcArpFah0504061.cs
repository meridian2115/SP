using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504061
    {
        public DcArpFah0504061()
        {
            FsAp0504061List = new HashSet<FsAp0504061List>();
            FsT10504061List = new HashSet<FsT10504061List>();
            FsT20504061List = new HashSet<FsT20504061List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PUfosGuid { get; set; }
        public string Npp { get; set; }
        public string Nmreg { get; set; }
        public string Instcd { get; set; }
        public string Nminst { get; set; }
        public string PCalcSet { get; set; }
        public string PCalcSetn { get; set; }
        public string PRptSetCode { get; set; }
        public string PRptSetCoden { get; set; }
        public string PReportType { get; set; }
        public string PReportTypen { get; set; }
        public DateTime? PBeginDate { get; set; }
        public DateTime? PDate { get; set; }
        public string PPostStatus { get; set; }
        public string PPostStatusn { get; set; }
        public string PSegment { get; set; }
        public string PSegmentn { get; set; }
        public string PUfk { get; set; }
        public string PBudgetLevelCode { get; set; }
        public string PBudgetLevelCoden { get; set; }
        public string PBudgetCode { get; set; }
        public string PBudgetCoden { get; set; }
        public string PSuFinOrg { get; set; }
        public string PFundstype { get; set; }
        public string PFundstypen { get; set; }
        public string PFundSource { get; set; }
        public string PFundSourcen { get; set; }
        public string PDocGroupType { get; set; }
        public string PDocGroupTypen { get; set; }
        public string PDocGroupTypen1 { get; set; }
        public string HDocGroupTypen2 { get; set; }
        public string PTofkCoden { get; set; }
        public string PDeptName { get; set; }
        public DateTime? PReportDate { get; set; }
        public string PAlwaysPrintFlagE { get; set; }
        public string PAlwaysPrintFlag { get; set; }
        public string PNullString { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public string PStat { get; set; }
        public string PPhase { get; set; }
        public string PTextCompletion { get; set; }
        public string PSystem { get; set; }
        public string HRmonthDate { get; set; }
        public DateTime? HReportDate { get; set; }
        public string HOkud { get; set; }
        public string HNmUfk { get; set; }
        public string HDepartment { get; set; }
        public string HNmBudg { get; set; }
        public string HLboType { get; set; }
        public string HNmUfk1 { get; set; }
        public string HNmBudg1 { get; set; }
        public string HOkpo { get; set; }
        public string HOkpo1 { get; set; }
        public string HOkei { get; set; }
        public decimal? R1Sum { get; set; }
        public decimal? R2Sum { get; set; }
        public decimal? R3Sum { get; set; }
        public decimal? R4Sum { get; set; }
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
        public DateTime? ApReportDate { get; set; }
        public string PTofkCode { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string Vr { get; set; }

        public virtual ICollection<FsAp0504061List> FsAp0504061List { get; set; }
        public virtual ICollection<FsT10504061List> FsT10504061List { get; set; }
        public virtual ICollection<FsT20504061List> FsT20504061List { get; set; }
    }
}
