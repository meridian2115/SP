using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArp0503320Megatable
    {
        public DcArp0503320Megatable()
        {
            FsTab0503320actList = new HashSet<FsTab0503320actList>();
            FsTab0503320konsList = new HashSet<FsTab0503320konsList>();
            FsTab0503320pasList = new HashSet<FsTab0503320pasList>();
            FsTestTestList = new HashSet<FsTestTestList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string PfnLeader { get; set; }
        public string PfnChiefAcc { get; set; }
        public string PfnLeaderOfFes { get; set; }
        public string PfnPostLeader { get; set; }
        public string PfnPostChiefAcc { get; set; }
        public string PfnPostLeaderOf { get; set; }
        public string PfnExecutor { get; set; }
        public string PfnPostExecutor { get; set; }
        public string PfnPhone { get; set; }
        public string P2Surrogat { get; set; }
        public string P2ReportNum { get; set; }
        public string P2Codereportform { get; set; }
        public string P2HrErNameOfEntity { get; set; }
        public string P2HrErCodeOfEntity { get; set; }
        public string P2HrErOkpo { get; set; }
        public string P2HrErOktmo { get; set; }
        public string P2HrErGlavaBk { get; set; }
        public string P2HrErSubotch { get; set; }
        public string P2HrErInn { get; set; }
        public string P2HrErCdofentalt { get; set; }
        public string P2HrErPrcdofent { get; set; }
        public string P2HrErPrnmofent { get; set; }
        public string P2HrPeriodType { get; set; }
        public DateTime? P2HrReportDate { get; set; }
        public string P2HrInstitutionCode { get; set; }
        public string P2HrAccountcode { get; set; }
        public bool? P2HrUsersing { get; set; }
        public string P2HrAiCode { get; set; }
        public string P2HrAiName { get; set; }
        public string P2HrNamtip { get; set; }
        public string P2HrTypeactivityname { get; set; }
        public string P2HrTypeactivitycode { get; set; }
        public string P2HrBtCodeOfBudget { get; set; }
        public string P2HrBtNameOfBudget { get; set; }
        public string P2HrBtCodeOfType { get; set; }
        public string P2HrTofkcode { get; set; }
        public string P2HrUbpcode { get; set; }
        public DateTime? P2HrDataStartactive { get; set; }
        public DateTime? P2HrDataEndactive { get; set; }
        public string P2HrCdrf { get; set; }
        public string P2HrIndicators { get; set; }
        public string P2HrCodf { get; set; }
        public string P2HrOffice { get; set; }
        public string P2HrReorg { get; set; }
        public string P2HrGlavaReorg { get; set; }
        public string P2HrOktmoReorg { get; set; }
        public string P2HrCodeReorg { get; set; }
        public string P2HrReorgTex { get; set; }
        public bool? P2HrCheckreorg { get; set; }
        public string P2StatctrlsStateidc { get; set; }
        public string P2StatctrlsStatebdc { get; set; }
        public string P2StatctrlsStateflc { get; set; }
        public string P2StatctrlsStateexc { get; set; }
        public string P2StatctrlsGuidflc { get; set; }
        public string P2StatctrlsGuididc { get; set; }
        public string P2StatctrlsGuidbdc { get; set; }
        public string P2StatctrlsGuidexc { get; set; }
        public string P2StatctrlsGuidprimeexc { get; set; }
        public string P2Currentapprover { get; set; }
        public string P2Nextapprover { get; set; }
        public string P2Fullyapproved { get; set; }
        public string P2Approvalstate { get; set; }
        public string P2Typeagreement { get; set; }
        public string P2Namereportform { get; set; }
        public string P2Reporttype { get; set; }
        public string P2Filename { get; set; }
        public DateTime? P2Importdatetime { get; set; }
        public string P2ComplectCode { get; set; }
        public string P2PeriodCode { get; set; }
        public string P2ImportedWErrors { get; set; }
        public DateTime? P2TimeSubmit { get; set; }
        public string P2Reasons { get; set; }
        public string P2Reporttypemou { get; set; }
        public string P2Lastreport { get; set; }
        public string P2Guidconsolid { get; set; }
        public DateTime? P2Datestatusupdates { get; set; }
        public string P2Guidprimary { get; set; }
        public string P2Guidconsolidated { get; set; }
        public string P2Fksegmentcode { get; set; }
        public string P2Fksystem { get; set; }
        public string P2Stateasfk { get; set; }
        public string P2Asfkdocguid { get; set; }
        public string P2Printname { get; set; }
        public string P2FgSo { get; set; }
        public string P2FgPo { get; set; }
        public string P2ApLoginGb { get; set; }
        public string P2ApLoginRfes { get; set; }
        public string P2ApLoginR { get; set; }
        public string P2ApLoginOip { get; set; }
        public string P2ApFioGb { get; set; }
        public string P2ApFioRfes { get; set; }
        public string P2ApFioR { get; set; }
        public string P2ApFioOip { get; set; }
        public string P2ApDepartmentGb { get; set; }
        public string P2ApDepartmentRfes { get; set; }
        public string P2ApDepartmentR { get; set; }
        public string P2ApDepartmentOip { get; set; }
        public string P2ApPostfieldR { get; set; }
        public string P2ApPostfieldRfes { get; set; }
        public string P2ApPostfieldGb { get; set; }
        public string P2ApPostfieldOip { get; set; }
        public bool? P2ApScipsoglas { get; set; }
        public string P2ApSoglasGb { get; set; }
        public string P2ApSoglasRfes { get; set; }
        public string P2ApSoglasR { get; set; }
        public string P2ApSoglasOip { get; set; }
        public string P2ApNoteGb { get; set; }
        public string P2ApNoteRfes { get; set; }
        public string P2ApNoteR { get; set; }
        public string P2ApNoteOip { get; set; }
        public string P2ApSoglasCnb { get; set; }
        public string P2ApNoteCnb { get; set; }
        public string P2SignLeader { get; set; }
        public string P2SignChiefAcc { get; set; }
        public string P2SignLeaderOfFes { get; set; }
        public string P2SignPostLeader { get; set; }
        public string P2SignPostChiefAcc { get; set; }
        public string P2SignPostLeaderOf { get; set; }
        public string P2SignExecutor { get; set; }
        public string P2SignPostExecutor { get; set; }
        public string P2SignPhone { get; set; }
        public string P2SignFioOip { get; set; }
        public string P2SignPostfieldOip { get; set; }
        public string P2SignLdrFlg { get; set; }
        public string P2SignChfFlg { get; set; }
        public string P2SignLdrFesFlg { get; set; }
        public string P2SignOipFlg { get; set; }
        public string P2SignLdrCaFlg { get; set; }
        public bool? P2SignReorgSogl { get; set; }
        public string P2SignReorgAssign { get; set; }
        public string P2SignReorgNote { get; set; }
        public string P2Reqstate { get; set; }
        public DateTime? P2VnkFormationDate { get; set; }
        public bool? P2CheckBlockerFlk { get; set; }
        public bool? P2CheckBlockerVdk { get; set; }
        public bool? P2CheckBlockerMdk { get; set; }
        public string P2AgreedReorg { get; set; }
        public string P2StateEpbs { get; set; }
        public string P2Guidticket { get; set; }
        public string P2Guidreceipt { get; set; }
        public string P2CnbCode { get; set; }
        public string P2CnbName { get; set; }
        public string P2CnbOgrn { get; set; }
        public string P2CnbInn { get; set; }
        public string P2CnbKpp { get; set; }
        public string P2CnbCaLeader { get; set; }
        public string P2CnbCaExecutor { get; set; }
        public string P2CnbPostCaLeader { get; set; }
        public string P2CnbPostCaExecutor { get; set; }
        public string P2CnbCaExecutorMail { get; set; }
        public string P2CaExecutorMail { get; set; }
        public string P2Location { get; set; }
        public string P2AllPrint { get; set; }
        public bool? P2SubDiv { get; set; }
        public string P2Okved { get; set; }
        public string P2ImportSystem { get; set; }
        public string P2FahFormed { get; set; }
        public string P2GuidReportTech { get; set; }
        public string P2StatusFah { get; set; }
        public string P2PhaseFah { get; set; }
        public string P2TextFah { get; set; }
        public string P2RplReportNum { get; set; }
        public string P2RplErNameOfEntity { get; set; }
        public string P2RplErCodeOfEntity { get; set; }
        public string P2RplErOkpo { get; set; }
        public string P2RplErOktmo { get; set; }
        public string P2RplErGlavaBk { get; set; }
        public string P2RplErSubotch { get; set; }
        public string P2RplErInn { get; set; }
        public string P2RplErCdofentalt { get; set; }
        public string P2RplErPrcdofent { get; set; }
        public string P2RplErPrnmofent { get; set; }
        public string P2RplReasons1 { get; set; }
        public string P2RplReasons2 { get; set; }
        public string P2RplStateRpl { get; set; }
        public string P2RplGuidrpl { get; set; }
        public string P2RplNameOfBudget { get; set; }
        public bool? P2RplFlg { get; set; }
        public string P2SrcCons { get; set; }
        public string P2DocsToUpdate { get; set; }
        public string P2StatePiao { get; set; }

        public virtual ICollection<FsTab0503320actList> FsTab0503320actList { get; set; }
        public virtual ICollection<FsTab0503320konsList> FsTab0503320konsList { get; set; }
        public virtual ICollection<FsTab0503320pasList> FsTab0503320pasList { get; set; }
        public virtual ICollection<FsTestTestList> FsTestTestList { get; set; }
    }
}
