using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFamPaymorderdbD06
    {
        public DcFamPaymorderdbD06()
        {
            FsFAccone06List = new HashSet<FsFAccone06List>();
            FsFEr06List = new HashSet<FsFEr06List>();
            FsKooFamReturnkooD06List = new HashSet<FsKooFamReturnkooD06List>();
            FsLaAgrD06List = new HashSet<FsLaAgrD06List>();
            FsLaAppD06List = new HashSet<FsLaAppD06List>();
            FsLaExecD06List = new HashSet<FsLaExecD06List>();
            FsOebsErrorsD06List = new HashSet<FsOebsErrorsD06List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string EsEdno { get; set; }
        public DateTime? EsEddate { get; set; }
        public string EsEdauthor { get; set; }
        public string EsEdreceiver { get; set; }
        public string AdiOpertype { get; set; }
        public string AdiPayorder { get; set; }
        public DateTime? AdiReceiptdate { get; set; }
        public DateTime? AdiFiledate { get; set; }
        public DateTime? AdiChargeoffdate { get; set; }
        public string AdiSystemcode { get; set; }
        public string AdiPaymentid { get; set; }
        public DateTime? AdiExecdated33 { get; set; }
        public bool? AdiOffbankpayment { get; set; }
        public string AdiReturnrequest { get; set; }
        public string BrePayview { get; set; }
        public decimal? BrePaysum { get; set; }
        public string BrePaypriority { get; set; }
        public DateTime? BreReqsetdat { get; set; }
        public string AccdocNum { get; set; }
        public DateTime? AccdocDated { get; set; }
        public string AccdocGuid { get; set; }
        public string PInn { get; set; }
        public string PKpp { get; set; }
        public string PName { get; set; }
        public string PBik { get; set; }
        public string PCorracc { get; set; }
        public string PBankname { get; set; }
        public string PCheckacc { get; set; }
        public string RInn { get; set; }
        public string RKpp { get; set; }
        public string RName { get; set; }
        public string RBik { get; set; }
        public string RCorracc { get; set; }
        public string RBankname { get; set; }
        public string RCheckacc { get; set; }
        public string DfPaypurpose { get; set; }
        public DateTime? DfPaydate { get; set; }
        public string DfStatusnm { get; set; }
        public string DfGuidrnp { get; set; }
        public string DfDocnumrnp { get; set; }
        public DateTime? DfDocdaternp { get; set; }
        public string DfStatusrnp { get; set; }
        public DateTime? DfDatetimesentrnp { get; set; }
        public string DfPaysource { get; set; }
        public string DfPaysourcedesc { get; set; }
        public string DfSignChiefAcc { get; set; }
        public string DfSignPostChiefAcc { get; set; }
        public string DfSignExecutor { get; set; }
        public string DfSignPostExecutor { get; set; }
        public string DfSignPhone { get; set; }
        public string DfSignLeader { get; set; }
        public string DfSignPostLeader { get; set; }
        public DateTime? DfSignData { get; set; }
        public DateTime? DfSignDatesignexec { get; set; }
        public DateTime? DfSignDatesignldr { get; set; }
        public DateTime? DfSignDatesignacc { get; set; }
        public string TaxPayreason { get; set; }
        public string TaxPeriod { get; set; }
        public string TaxDocno { get; set; }
        public DateTime? TaxDocdate { get; set; }
        public string TaxPaytype { get; set; }
        public string TaxKbk { get; set; }
        public string TaxOktmo { get; set; }
        public string TaxDrawstat { get; set; }
        public string KzDocnum { get; set; }
        public DateTime? KzDocdate { get; set; }
        public string KzDocguid { get; set; }
        public string DfReservef { get; set; }
        public string DfPaypurpose2 { get; set; }
        public string DfSignretfund { get; set; }
        public string DfTerrorextrem { get; set; }
        public string KooReturnflag { get; set; }
        public string KooTofkcodeflag { get; set; }
        public string KooDocnum { get; set; }
        public DateTime? KooDocdate { get; set; }
        public string KooDocguid { get; set; }
        public string SysThfield1 { get; set; }
        public string SysThfield2 { get; set; }
        public string SysThfield3 { get; set; }
        public string SysThfield4 { get; set; }
        public string SysStatuskz { get; set; }
        public string SysStatusth { get; set; }
        public string SysMsg { get; set; }
        public string SysIncludeKz { get; set; }
        public string SysCheckFlk { get; set; }
        public string SysIncludeRnp { get; set; }
        public string SysExecutedState { get; set; }
        public string SysGuidstring { get; set; }
        public string SysClobfield { get; set; }
        public DateTime? SysFlkdatetime { get; set; }
        public string SysSumtext { get; set; }
        public string SysStatusbankenum { get; set; }
        public string SysTehpole { get; set; }
        public string SysEdguid { get; set; }
        public string SysGuidpp { get; set; }
        public string SysCurrorg { get; set; }
        public string SysCancellationFlag { get; set; }
        public string SysGuidreqcancel { get; set; }
        public string SysSenderid { get; set; }
        public string SysFilename { get; set; }
        public string SysDoctype { get; set; }
        public string SysGuidzkr { get; set; }
        public string SysReturnstate { get; set; }
        public string ErCode { get; set; }
        public string ErText { get; set; }
        public string ErStatus { get; set; }
        public string ErStatus2 { get; set; }
        public string FXml { get; set; }
        public string FTofkCode { get; set; }
        public string FRTofkCode { get; set; }
        public string FModifyStat { get; set; }
        public string FReserveStat { get; set; }
        public string FCreatefinalStat { get; set; }
        public string FMarkjournalStat { get; set; }
        public string FAccflag { get; set; }
        public string FAccexist { get; set; }
        public bool? LaSkipappr { get; set; }
        public string LaAmountrowexecutor { get; set; }
        public string LaAmountrowagreer { get; set; }
        public string LaAmountrowapprover { get; set; }
        public string ZhkuIpd { get; set; }
        public DateTime? ZhkuPrd { get; set; }
        public string ZhkuEls { get; set; }
        public string ZhkuZhku { get; set; }

        public virtual ICollection<FsFAccone06List> FsFAccone06List { get; set; }
        public virtual ICollection<FsFEr06List> FsFEr06List { get; set; }
        public virtual ICollection<FsKooFamReturnkooD06List> FsKooFamReturnkooD06List { get; set; }
        public virtual ICollection<FsLaAgrD06List> FsLaAgrD06List { get; set; }
        public virtual ICollection<FsLaAppD06List> FsLaAppD06List { get; set; }
        public virtual ICollection<FsLaExecD06List> FsLaExecD06List { get; set; }
        public virtual ICollection<FsOebsErrorsD06List> FsOebsErrorsD06List { get; set; }
    }
}
