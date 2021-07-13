using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah0504833
    {
        public DcArpFah0504833()
        {
            Fs833ApprovalList = new HashSet<Fs833ApprovalList>();
            FsAcconeList = new HashSet<FsAcconeList>();
            FsAccrecords1List = new HashSet<FsAccrecords1List>();
            FsAccrecordsList = new HashSet<FsAccrecordsList>();
            FsEr833List = new HashSet<FsEr833List>();
            FsT0504833List = new HashSet<FsT0504833List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string NumDoc { get; set; }
        public string TofkCode { get; set; }
        public string TypeDoc { get; set; }
        public string NameDoc { get; set; }
        public string StateDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string Institution { get; set; }
        public string NameOp { get; set; }
        public string Okpo { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Office { get; set; }
        public string CdLedgerbook { get; set; }
        public string Ledgerbook { get; set; }
        public string Note { get; set; }
        public string Budget { get; set; }
        public string Inst { get; set; }
        public decimal? Summ { get; set; }
        public string DtKbk { get; set; }
        public string DtKvfo { get; set; }
        public string DtPls { get; set; }
        public string DtLs { get; set; }
        public string DtKs { get; set; }
        public string DtBo { get; set; }
        public string DtFaip { get; set; }
        public string DtOktmo { get; set; }
        public string DtConcat { get; set; }
        public string DtKsbu { get; set; }
        public string DtKppv { get; set; }
        public string DtNpp { get; set; }
        public string DtKosgu { get; set; }
        public string DtPuch { get; set; }
        public string DtPzo { get; set; }
        public string DtFo { get; set; }
        public string DtPls1 { get; set; }
        public string DtKvfo1 { get; set; }
        public string DtPls2 { get; set; }
        public string DtKvfo2 { get; set; }
        public string DtKoo { get; set; }
        public string CtKbk { get; set; }
        public string CtKvfo { get; set; }
        public string CtPls { get; set; }
        public string CtLs { get; set; }
        public string CtKs { get; set; }
        public string CtBo { get; set; }
        public string CtFaip { get; set; }
        public string CtOktmo { get; set; }
        public string CtConcat { get; set; }
        public string CtKsbu { get; set; }
        public string CtKppv { get; set; }
        public string CtNpp { get; set; }
        public string CtKosgu { get; set; }
        public string CtPuch { get; set; }
        public string CtPzo { get; set; }
        public string CtFo { get; set; }
        public string CtPls1 { get; set; }
        public string CtKvfo1 { get; set; }
        public string CtPls2 { get; set; }
        public string CtKvfo2 { get; set; }
        public string CtKoo { get; set; }
        public string Kont { get; set; }
        public string Okv { get; set; }
        public string Finyear { get; set; }
        public string Period { get; set; }
        public string Kurs { get; set; }
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
        public string PExecutorName { get; set; }
        public string PExecutorPosition { get; set; }
        public string Stpost { get; set; }
        public string Nmaccrec { get; set; }
        public string Nmaccrec1 { get; set; }
        public string KbkBudclascd { get; set; }
        public string KbkType { get; set; }
        public string KbkCdincm { get; set; }
        public string KbkCdsfbd { get; set; }
        public string KbkChief { get; set; }
        public string KbkCdtpincm { get; set; }
        public string KbkCdsbtppincm { get; set; }
        public string KbkCdscsbsc { get; set; }
        public string KbkCdtrgtexpnd { get; set; }
        public string KbkCdtpexp { get; set; }
        public string KbkCdgrsbgrsbdf { get; set; }
        public string KbkCdartsbdf { get; set; }
        public string KbkCdtpsbdf { get; set; }
        public string KbkCdstmngop { get; set; }
        public string KbkAnalyticcode { get; set; }
        public string KbkCdincom { get; set; }
        public string Moutn { get; set; }
        public string Year2 { get; set; }
        public string OperFt { get; set; }
        public string BudFt { get; set; }
        public string Gdocid { get; set; }
        public string Xml { get; set; }
        public bool? Role { get; set; }
        public string Signlowcontrol { get; set; }
        public string Basislowcontrol { get; set; }
        public string Bsg { get; set; }
        public string Typesofdoc { get; set; }
        public string PExecutor { get; set; }
        public string PExecutorRole { get; set; }
        public DateTime? DateR { get; set; }
        public DateTime? DateGb { get; set; }
        public DateTime? DateRfes { get; set; }
        public DateTime? DateExecutor { get; set; }
        public DateTime? DateOffexecutor { get; set; }
        public string CdCs { get; set; }

        public virtual ICollection<Fs833ApprovalList> Fs833ApprovalList { get; set; }
        public virtual ICollection<FsAcconeList> FsAcconeList { get; set; }
        public virtual ICollection<FsAccrecords1List> FsAccrecords1List { get; set; }
        public virtual ICollection<FsAccrecordsList> FsAccrecordsList { get; set; }
        public virtual ICollection<FsEr833List> FsEr833List { get; set; }
        public virtual ICollection<FsT0504833List> FsT0504833List { get; set; }
    }
}
