using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504062
    {
        public DcArpFah0504062()
        {
            FsAp0504062List = new HashSet<FsAp0504062List>();
            FsT10504062List = new HashSet<FsT10504062List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PUfosGuid { get; set; }
        public string Npp { get; set; }
        public string Nmreg { get; set; }
        public string Instcd { get; set; }
        public string Nminst { get; set; }
        public DateTime? PReportDate { get; set; }
        public string PBudgetCode { get; set; }
        public string PNmBudget { get; set; }
        public string PBudgetTypeCode { get; set; }
        public string PBudgetLvlCode { get; set; }
        public string PLedger { get; set; }
        public string PLedgerSet { get; set; }
        public string PLboType { get; set; }
        public string PLboTypeN { get; set; }
        public string PLboTypeF { get; set; }
        public string POfkCor { get; set; }
        public string PDepartment { get; set; }
        public string PUfk { get; set; }
        public string PNmUfk { get; set; }
        public string POfkCorArr { get; set; }
        public string PNmUfk1 { get; set; }
        public DateTime? PReportPrepareDate { get; set; }
        public string PEmptyData { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public string PStat { get; set; }
        public string PPhase { get; set; }
        public string PTextCompletion { get; set; }
        public string PSystem { get; set; }
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
        public DateTime? HReportDate { get; set; }
        public string HNmUfk { get; set; }
        public string HDepartment { get; set; }
        public string HNmBudg { get; set; }
        public string HLboType { get; set; }
        public string HNmUfk1 { get; set; }
        public string HNmBudg1 { get; set; }
        public string HOkud { get; set; }
        public string HOkpo { get; set; }
        public string HGlBk { get; set; }
        public string HOktmo { get; set; }
        public string HOkpo1 { get; set; }
        public string HGlBk1 { get; set; }
        public string HOktmo1 { get; set; }
        public string HOkei { get; set; }
        public decimal? S1T2 { get; set; }
        public decimal? S1T3 { get; set; }
        public string PManagerPosition { get; set; }
        public string PManagerName { get; set; }
        public string PExecutorName { get; set; }
        public string PExecutorPosition { get; set; }
        public string PManagerRole { get; set; }
        public string PExecutorRole { get; set; }
        public string PTofkCode { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string Vr { get; set; }

        public virtual ICollection<FsAp0504062List> FsAp0504062List { get; set; }
        public virtual ICollection<FsT10504062List> FsT10504062List { get; set; }
    }
}
