using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFamPaymordercrD09
    {
        public DcFamPaymordercrD09()
        {
            FsFAcconeList = new HashSet<FsFAcconeList>();
            FsFEr09List = new HashSet<FsFEr09List>();
            FsKooFamReturnkooD09List = new HashSet<FsKooFamReturnkooD09List>();
            FsLinkdcD09List = new HashSet<FsLinkdcD09List>();
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
        public string AdiTypesess { get; set; }
        public string AdiNumses { get; set; }
        public DateTime? AdiReqsettime { get; set; }
        public string AdiSystemfasten { get; set; }
        public string AdiPostingguid { get; set; }
        public string AdiStatusbyextract { get; set; }
        public string AdiStatusbyextract2 { get; set; }
        public string AdiStatusbyextractenum { get; set; }
        public string AdiEd2Edno { get; set; }
        public DateTime? AdiEd2Eddate { get; set; }
        public string AdiEd2Edauthor { get; set; }
        public DateTime? BisDebitdat { get; set; }
        public DateTime? BisCreditdat { get; set; }
        public string BisScenario { get; set; }
        public string AdiSystemrerecipirt { get; set; }
        public string AdiTypeed { get; set; }
        public string BrePayview { get; set; }
        public string BrePaypriority { get; set; }
        public decimal? BrePaysum { get; set; }
        public DateTime? BreReqsetdat { get; set; }
        public string BreCreateorg { get; set; }
        public DateTime? BreDocdate { get; set; }
        public string BreDocnum { get; set; }
        public string AccdocDocnum { get; set; }
        public DateTime? AccdocDocdate { get; set; }
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
        public string DfReservef { get; set; }
        public string DfPaypurpose2 { get; set; }
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
        public string TaxDrawstat { get; set; }
        public string TaxKbk { get; set; }
        public string TaxOktmo { get; set; }
        public string TaxPayreason { get; set; }
        public string TaxPeriod { get; set; }
        public string TaxDocno { get; set; }
        public string TaxDocdate { get; set; }
        public string TaxPaytype { get; set; }
        public string KzDocnum { get; set; }
        public DateTime? KzDocdate { get; set; }
        public string KzDocguid { get; set; }
        public string DfResfield { get; set; }
        public string KooReturnflag { get; set; }
        public string KooTofkcodeflag { get; set; }
        public string KooDocnum { get; set; }
        public DateTime? KooDocdate { get; set; }
        public string KooDocguid { get; set; }
        public string FXml { get; set; }
        public string FTofkCode { get; set; }
        public string FAccflag { get; set; }
        public string FAccexist { get; set; }
        public string FPTofkCode { get; set; }
        public string FRTofkCode { get; set; }
        public string SysTehpole { get; set; }
        public string SysSumtext { get; set; }
        public string SysGuidppdb { get; set; }
        public string SysCurrorg { get; set; }
        public string SysGuidkzoReceipt { get; set; }
        public string SysFilename { get; set; }
        public string SysMigrflag { get; set; }
        public string SysTransportstatus { get; set; }
        public string SysTrnststtsflg { get; set; }

        public virtual ICollection<FsFAcconeList> FsFAcconeList { get; set; }
        public virtual ICollection<FsFEr09List> FsFEr09List { get; set; }
        public virtual ICollection<FsKooFamReturnkooD09List> FsKooFamReturnkooD09List { get; set; }
        public virtual ICollection<FsLinkdcD09List> FsLinkdcD09List { get; set; }
    }
}
