using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503175
    {
        public DcArpReport0503175()
        {
            FsS1T1List = new HashSet<FsS1T1List>();
            FsS1T2List = new HashSet<FsS1T2List>();
            FsS2T1List = new HashSet<FsS2T1List>();
            FsS2T2List = new HashSet<FsS2T2List>();
            FsS3T1List = new HashSet<FsS3T1List>();
            FsS3T2List = new HashSet<FsS3T2List>();
            FsS4T1List = new HashSet<FsS4T1List>();
            FsS4T2List = new HashSet<FsS4T2List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? S1Sum { get; set; }
        public decimal? S2Sum { get; set; }
        public decimal? S3Sum { get; set; }
        public decimal? S4Sum { get; set; }
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
        public string P1Surrogat { get; set; }
        public string P1ReportNum { get; set; }
        public string P1Codereportform { get; set; }
        public string P1HrErNameOfEntity { get; set; }
        public string P1HrErCodeOfEntity { get; set; }
        public string P1HrErOkpo { get; set; }
        public string P1HrErOktmo { get; set; }
        public string P1HrErGlavaBk { get; set; }
        public string P1HrErSubotch { get; set; }
        public string P1HrErInn { get; set; }
        public string P1HrErCdofentalt { get; set; }
        public string P1HrErPrcdofent { get; set; }
        public string P1HrErPrnmofent { get; set; }
        public string P1HrPeriodType { get; set; }
        public DateTime? P1HrReportDate { get; set; }
        public string P1HrInstitutionCode { get; set; }
        public string P1HrAccountcode { get; set; }
        public bool? P1HrUsersing { get; set; }
        public string P1HrAiCode { get; set; }
        public string P1HrAiName { get; set; }
        public string P1HrNamtip { get; set; }
        public string P1HrTypeactivityname { get; set; }
        public string P1HrTypeactivitycode { get; set; }
        public string P1HrBtCodeOfBudget { get; set; }
        public string P1HrBtNameOfBudget { get; set; }
        public string P1HrBtCodeOfType { get; set; }
        public string P1HrTofkcode { get; set; }
        public string P1HrUbpcode { get; set; }
        public DateTime? P1HrDataStartactive { get; set; }
        public DateTime? P1HrDataEndactive { get; set; }
        public string P1HrCdrf { get; set; }
        public string P1HrIndicators { get; set; }
        public string P1HrCodf { get; set; }
        public string P1HrOffice { get; set; }
        public string P1HrReorg { get; set; }
        public string P1HrGlavaReorg { get; set; }
        public string P1HrOktmoReorg { get; set; }
        public string P1HrCodeReorg { get; set; }
        public string P1HrReorgTex { get; set; }
        public bool? P1HrCheckreorg { get; set; }
        public string P1StatctrlsStateidc { get; set; }
        public string P1StatctrlsStatebdc { get; set; }
        public string P1StatctrlsStateflc { get; set; }
        public string P1StatctrlsStateexc { get; set; }
        public string P1StatctrlsGuidflc { get; set; }
        public string P1StatctrlsGuididc { get; set; }
        public string P1StatctrlsGuidbdc { get; set; }
        public string P1StatctrlsGuidexc { get; set; }
        public string P1StatctrlsGuidprimeexc { get; set; }
        public string P1Currentapprover { get; set; }
        public string P1Nextapprover { get; set; }
        public string P1Fullyapproved { get; set; }
        public string P1Approvalstate { get; set; }
        public string P1Typeagreement { get; set; }
        public string P1Namereportform { get; set; }
        public string P1Reporttype { get; set; }
        public string P1Filename { get; set; }
        public DateTime? P1Importdatetime { get; set; }
        public string P1ComplectCode { get; set; }
        public string P1PeriodCode { get; set; }
        public string P1ImportedWErrors { get; set; }
        public DateTime? P1TimeSubmit { get; set; }
        public string P1Reasons { get; set; }
        public string P1Reporttypemou { get; set; }
        public string P1Lastreport { get; set; }
        public string P1Guidconsolid { get; set; }
        public DateTime? P1Datestatusupdates { get; set; }
        public string P1Guidprimary { get; set; }
        public string P1Guidconsolidated { get; set; }
        public string P1Fksegmentcode { get; set; }
        public string P1Fksystem { get; set; }
        public string P1Stateasfk { get; set; }
        public string P1Asfkdocguid { get; set; }
        public string P1Printname { get; set; }
        public string P1FgSo { get; set; }
        public string P1FgPo { get; set; }
        public string P1ApLoginGb { get; set; }
        public string P1ApLoginRfes { get; set; }
        public string P1ApLoginR { get; set; }
        public string P1ApLoginOip { get; set; }
        public string P1ApFioGb { get; set; }
        public string P1ApFioRfes { get; set; }
        public string P1ApFioR { get; set; }
        public string P1ApFioOip { get; set; }
        public string P1ApDepartmentGb { get; set; }
        public string P1ApDepartmentRfes { get; set; }
        public string P1ApDepartmentR { get; set; }
        public string P1ApDepartmentOip { get; set; }
        public string P1ApPostfieldR { get; set; }
        public string P1ApPostfieldRfes { get; set; }
        public string P1ApPostfieldGb { get; set; }
        public string P1ApPostfieldOip { get; set; }
        public bool? P1ApScipsoglas { get; set; }
        public string P1ApSoglasGb { get; set; }
        public string P1ApSoglasRfes { get; set; }
        public string P1ApSoglasR { get; set; }
        public string P1ApSoglasOip { get; set; }
        public string P1ApNoteGb { get; set; }
        public string P1ApNoteRfes { get; set; }
        public string P1ApNoteR { get; set; }
        public string P1ApNoteOip { get; set; }
        public string P1ApSoglasCnb { get; set; }
        public string P1ApNoteCnb { get; set; }
        public string P1SignLeader { get; set; }
        public string P1SignChiefAcc { get; set; }
        public string P1SignLeaderOfFes { get; set; }
        public string P1SignPostLeader { get; set; }
        public string P1SignPostChiefAcc { get; set; }
        public string P1SignPostLeaderOf { get; set; }
        public string P1SignExecutor { get; set; }
        public string P1SignPostExecutor { get; set; }
        public string P1SignPhone { get; set; }
        public string P1SignFioOip { get; set; }
        public string P1SignPostfieldOip { get; set; }
        public string P1SignLdrFlg { get; set; }
        public string P1SignChfFlg { get; set; }
        public string P1SignLdrFesFlg { get; set; }
        public string P1SignOipFlg { get; set; }
        public string P1SignLdrCaFlg { get; set; }
        public bool? P1SignReorgSogl { get; set; }
        public string P1SignReorgAssign { get; set; }
        public string P1SignReorgNote { get; set; }
        public string P1Reqstate { get; set; }
        public DateTime? P1VnkFormationDate { get; set; }
        public bool? P1CheckBlockerFlk { get; set; }
        public bool? P1CheckBlockerVdk { get; set; }
        public bool? P1CheckBlockerMdk { get; set; }
        public string P1AgreedReorg { get; set; }
        public string P1StateEpbs { get; set; }
        public string P1Guidticket { get; set; }
        public string P1Guidreceipt { get; set; }
        public string P1CnbCode { get; set; }
        public string P1CnbName { get; set; }
        public string P1CnbOgrn { get; set; }
        public string P1CnbInn { get; set; }
        public string P1CnbKpp { get; set; }
        public string P1CnbCaLeader { get; set; }
        public string P1CnbCaExecutor { get; set; }
        public string P1CnbPostCaLeader { get; set; }
        public string P1CnbPostCaExecutor { get; set; }
        public string P1CnbCaExecutorMail { get; set; }
        public string P1CaExecutorMail { get; set; }
        public string P1Location { get; set; }
        public string P1AllPrint { get; set; }
        public bool? P1SubDiv { get; set; }
        public string P1Okved { get; set; }
        public string P1ImportSystem { get; set; }
        public string P1FahFormed { get; set; }
        public string P1GuidReportTech { get; set; }
        public string P1StatusFah { get; set; }
        public string P1PhaseFah { get; set; }
        public string P1TextFah { get; set; }
        public string P1RplReportNum { get; set; }
        public string P1RplErNameOfEntity { get; set; }
        public string P1RplErCodeOfEntity { get; set; }
        public string P1RplErOkpo { get; set; }
        public string P1RplErOktmo { get; set; }
        public string P1RplErGlavaBk { get; set; }
        public string P1RplErSubotch { get; set; }
        public string P1RplErInn { get; set; }
        public string P1RplErCdofentalt { get; set; }
        public string P1RplErPrcdofent { get; set; }
        public string P1RplErPrnmofent { get; set; }
        public string P1RplReasons1 { get; set; }
        public string P1RplReasons2 { get; set; }
        public string P1RplStateRpl { get; set; }
        public string P1RplGuidrpl { get; set; }
        public string P1RplNameOfBudget { get; set; }
        public bool? P1RplFlg { get; set; }
        public string P1SrcCons { get; set; }
        public string P1DocsToUpdate { get; set; }
        public string P1StatePiao { get; set; }

        public virtual ICollection<FsS1T1List> FsS1T1List { get; set; }
        public virtual ICollection<FsS1T2List> FsS1T2List { get; set; }
        public virtual ICollection<FsS2T1List> FsS2T1List { get; set; }
        public virtual ICollection<FsS2T2List> FsS2T2List { get; set; }
        public virtual ICollection<FsS3T1List> FsS3T1List { get; set; }
        public virtual ICollection<FsS3T2List> FsS3T2List { get; set; }
        public virtual ICollection<FsS4T1List> FsS4T1List { get; set; }
        public virtual ICollection<FsS4T2List> FsS4T2List { get; set; }
    }
}
