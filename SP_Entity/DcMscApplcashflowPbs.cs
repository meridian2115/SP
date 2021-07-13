using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcMscApplcashflowPbs
    {
        public DcMscApplcashflowPbs()
        {
            FsLaAgrPbs801List = new HashSet<FsLaAgrPbs801List>();
            FsLaApaPbs801List = new HashSet<FsLaApaPbs801List>();
            FsLaApfPbs801List = new HashSet<FsLaApfPbs801List>();
            FsLaAprPbs801List = new HashSet<FsLaAprPbs801List>();
            FsLaExecPbs801List = new HashSet<FsLaExecPbs801List>();
            FsLafkAgrPbs801List = new HashSet<FsLafkAgrPbs801List>();
            FsLafkApaPbs801List = new HashSet<FsLafkApaPbs801List>();
            FsLafkApfPbs801List = new HashSet<FsLafkApfPbs801List>();
            FsLafkAprPbs801List = new HashSet<FsLafkAprPbs801List>();
            FsLafkExecPbs801List = new HashSet<FsLafkExecPbs801List>();
            FsSiAccrecSinglList = new HashSet<FsSiAccrecSinglList>();
            FsSiTabsiPbsList12 = new HashSet<FsSiTabsiPbsList12>();
            FsZrosnPbsList = new HashSet<FsZrosnPbsList>();
            FsZrstPbsList = new HashSet<FsZrstPbsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfGuid { get; set; }
        public DateTime? InfCreationdate { get; set; }
        public string ZrReqtype { get; set; }
        public string ZrRequestnum { get; set; }
        public string CusCode { get; set; }
        public string CusFullname { get; set; }
        public string CusAccountnumber { get; set; }
        public string CusInn { get; set; }
        public string CusKpp { get; set; }
        public string ZrInn { get; set; }
        public string GrbsCode { get; set; }
        public string GrbsUbpcode { get; set; }
        public string GrbsName { get; set; }
        public string OrfkCode { get; set; }
        public string OrfkName { get; set; }
        public string BtCode { get; set; }
        public string BtName { get; set; }
        public string FiFinancialinst { get; set; }
        public string FiOkpocode { get; set; }
        public DateTime? ZrDocdateisp { get; set; }
        public string ZrGuidsv { get; set; }
        public string ZrObligatnum { get; set; }
        public string PeCode { get; set; }
        public string PeExecution { get; set; }
        public string ZrFaipobjcode { get; set; }
        public decimal? ZrAmountv { get; set; }
        public string OkvCode { get; set; }
        public string OkvName { get; set; }
        public decimal? ZrAmountdoc { get; set; }
        public string PayAdvnpaysign { get; set; }
        public string PayPriority { get; set; }
        public string PayKind { get; set; }
        public string PayPurpose { get; set; }
        public string PayType { get; set; }
        public string ConName { get; set; }
        public string ConInn { get; set; }
        public string ConKpp { get; set; }
        public string ConAccountnum { get; set; }
        public string BnkAccnum { get; set; }
        public string BnkName { get; set; }
        public string BnkBik { get; set; }
        public string BnkCorraccnum { get; set; }
        public string ZrTaxpayerstatus { get; set; }
        public string ZrKbk { get; set; }
        public string OktCode { get; set; }
        public string OktName { get; set; }
        public string ZrIndexbasepayment { get; set; }
        public string ZrIndextaxperiod { get; set; }
        public string ZrIndexnumdoc { get; set; }
        public string ZrIndexdatedoc { get; set; }
        public string HdPosition { get; set; }
        public string HdFullname { get; set; }
        public string RePosition { get; set; }
        public string ReFullname { get; set; }
        public string ReTelephone { get; set; }
        public DateTime? ZrSigningdatepod { get; set; }
        public string MofkRequestnum { get; set; }
        public DateTime? MofkRegisdate { get; set; }
        public string MofkPosition { get; set; }
        public string MofkFullname { get; set; }
        public string MofkTelephone { get; set; }
        public string ZrSource { get; set; }
        public decimal? ZrRejectrub { get; set; }
        public decimal? ZrRejectval { get; set; }
        public string ZrOkud { get; set; }
        public string ZrCodeacc { get; set; }
        public string ZrFundsourcecode { get; set; }
        public decimal? ZrPercentnds { get; set; }
        public string ZrSrvcTofkCode { get; set; }
        public string SiRegisterinformaccguid { get; set; }
        public string SiHeadidcode { get; set; }
        public string SiRowidcode { get; set; }
        public string SiResultparam { get; set; }
        public string SiTextresultparam { get; set; }
        public string SiAccountnum { get; set; }
        public DateTime? SiExecutiondate { get; set; }
        public string SiRejectionreason { get; set; }
        public string SiRelevancesign { get; set; }
        public string SiTypeaccountnum { get; set; }
        public string SiDocinfo { get; set; }
        public string SiDateacc { get; set; }
        public string SiBudgclass { get; set; }
        public string SiKindactivity { get; set; }
        public string SiIndexacc { get; set; }
        public string SiOrganfk { get; set; }
        public string SiContour { get; set; }
        public string SiAcc { get; set; }
        public string SiUnderinst { get; set; }
        public string SiSubsidycode { get; set; }
        public string SiKind { get; set; }
        public string SiDocnumber { get; set; }
        public DateTime? GrbsControldategrbs { get; set; }
        public string GrbsControlflaggrbs { get; set; }
        public DateTime? DtfkControldatetofk { get; set; }
        public string DtfkControlflagtofk { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiPuioNmaccrec { get; set; }
        public string SiPuioNmaccrec1 { get; set; }
        public string SiLampgroupftas { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public DateTime? SiDateofacc { get; set; }
        public DateTime? SiDateoper { get; set; }
        public string SiGuidCancdocReq { get; set; }
        public string SiProtocolguid { get; set; }
        public DateTime? SiProtocoldate { get; set; }
        public string SiProtocolnum { get; set; }
        public bool? SiIndexedo { get; set; }
        public string SiNumkoo { get; set; }
        public string SiNumpp { get; set; }
        public DateTime? SiDatepp { get; set; }
        public string SiNumconsappl { get; set; }
        public DateTime? SiDateconsappl { get; set; }
        public string SiRegnumbo { get; set; }
        public bool? SiTransferbankcard { get; set; }
        public bool? SiAutobo { get; set; }
        public bool? SiPayreqid { get; set; }
        public bool? SiForcedpay { get; set; }
        public bool? SiAcctotalbalance { get; set; }
        public bool? SiAutosanction { get; set; }
        public string SiNumreinforcedkoo { get; set; }
        public string SiDateval { get; set; }
        public string SiNumboRec { get; set; }
        public string SiNumdoRec { get; set; }
        public string SiFaipobjcode { get; set; }
        public bool? SiFundslastyear { get; set; }
        public string SiReqpayAccnum { get; set; }
        public string SiReqpayBik { get; set; }
        public string SiReqpayName { get; set; }
        public string SiReqpayCorraccnum { get; set; }
        public string SiLampgroupbank { get; set; }
        public string SiParentsystype { get; set; }
        public string SiGuidPaymOrder { get; set; }
        public DateTime? SiDateofaccrec { get; set; }
        public DateTime? SiDateoperrec { get; set; }
        public string SiRecGrbscode { get; set; }
        public string SiUvippguid { get; set; }
        public string SiUvippnum { get; set; }
        public DateTime? SiUvippdate { get; set; }
        public DateTime? SiDaterecord { get; set; }
        public string SiClntProtocolguid { get; set; }
        public DateTime? SiClntProtocoldate { get; set; }
        public string SiClntProtocolnum { get; set; }
        public string SiPayKind { get; set; }
        public string SiSourceTech { get; set; }
        public string SiImporteddoc { get; set; }
        public string SiClntLampgroupfk { get; set; }
        public string SiClntLampgrouppuio { get; set; }
        public string SiClntLampgroupbank { get; set; }
        public string SiCodeaccRec { get; set; }
        public string SiSelforfkcode { get; set; }
        public DateTime? SiDateofaccstrn { get; set; }
        public DateTime? SiDateentrtofk { get; set; }
        public string SiBudgettypeRec { get; set; }
        public string SiBudgetcodeRec { get; set; }
        public string SiTofkAcc { get; set; }
        public string SiCodeRcPay { get; set; }
        public string SiNumzoz { get; set; }
        public DateTime? SiDatezoz { get; set; }
        public string SiGuidPpNvs { get; set; }
        public string SiOrgAuthCode { get; set; }
        public bool? SiAutodo { get; set; }
        public string SiGuidDo { get; set; }
        public string SiGuidBo { get; set; }
        public string SiGuidDoRec { get; set; }
        public string SiGuidBoRec { get; set; }
        public bool? SiAutoboRec { get; set; }
        public bool? SiAutodoRec { get; set; }
        public string SiGuidAutodo { get; set; }
        public string SiGuidAutobo { get; set; }
        public string SiRegnumdo { get; set; }
        public string SiLampaboAdo { get; set; }
        public string SiTofkOpen { get; set; }
        public bool? SiSignBalboSnd { get; set; }
        public bool? SiSignPofrSnd { get; set; }
        public bool? SiSignBalboRec { get; set; }
        public bool? SiSignPofrRec { get; set; }
        public string SiGuidAdoChange { get; set; }
        public string SiGuidAboChange { get; set; }
        public bool? SiSignDoSnd { get; set; }
        public bool? SiSignDoRec { get; set; }
        public string SiOrgcodeRec { get; set; }
        public string SiWassaved { get; set; }
        public string SiReceiptpurEbRslt { get; set; }
        public string SiKbkctrlbalancepofrrec { get; set; }
        public string SiKbkctrlbalancepofrpay { get; set; }
        public string SiAdvnpaysignRec { get; set; }
        public string SiNumdoPay { get; set; }
        public string SiSigncashflowrecov { get; set; }
        public string SiSigncashflowref { get; set; }
        public string SiGuidAutodoRec { get; set; }
        public string SiGuidAutoboRec { get; set; }
        public string SiLampado { get; set; }
        public string SiLampabo { get; set; }
        public string TsCodesvr { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }
        public decimal? LaAmountrowappacc { get; set; }
        public decimal? LaAmountrowappfes { get; set; }
        public string LaLoginlistexecutor { get; set; }
        public string LaLoginlistagreer { get; set; }
        public string LaLoginlistapprover { get; set; }
        public string LaLoginlistappacc { get; set; }
        public string LaLoginlistappfes { get; set; }
        public string LaApprovalstep { get; set; }
        public bool? LafkSkipappr { get; set; }
        public decimal? LafkAmountrowexecutor { get; set; }
        public decimal? LafkAmountrowagreer { get; set; }
        public decimal? LafkAmountrowapprover { get; set; }
        public decimal? LafkAmountrowappacc { get; set; }
        public decimal? LafkAmountrowappfes { get; set; }
        public string LafkLoginlistexecutor { get; set; }
        public string LafkLoginlistagreer { get; set; }
        public string LafkLoginlistapprover { get; set; }
        public string LafkLoginlistappacc { get; set; }
        public string LafkLoginlistappfes { get; set; }
        public string LafkApprovalstep { get; set; }
        public string IpzIdpd { get; set; }
        public string IpzPayperiod { get; set; }
        public string IpzSingleacc { get; set; }
        public string IpzIdzhku { get; set; }
        public string ZrInctypecode { get; set; }

        public virtual ICollection<FsLaAgrPbs801List> FsLaAgrPbs801List { get; set; }
        public virtual ICollection<FsLaApaPbs801List> FsLaApaPbs801List { get; set; }
        public virtual ICollection<FsLaApfPbs801List> FsLaApfPbs801List { get; set; }
        public virtual ICollection<FsLaAprPbs801List> FsLaAprPbs801List { get; set; }
        public virtual ICollection<FsLaExecPbs801List> FsLaExecPbs801List { get; set; }
        public virtual ICollection<FsLafkAgrPbs801List> FsLafkAgrPbs801List { get; set; }
        public virtual ICollection<FsLafkApaPbs801List> FsLafkApaPbs801List { get; set; }
        public virtual ICollection<FsLafkApfPbs801List> FsLafkApfPbs801List { get; set; }
        public virtual ICollection<FsLafkAprPbs801List> FsLafkAprPbs801List { get; set; }
        public virtual ICollection<FsLafkExecPbs801List> FsLafkExecPbs801List { get; set; }
        public virtual ICollection<FsSiAccrecSinglList> FsSiAccrecSinglList { get; set; }
        public virtual ICollection<FsSiTabsiPbsList12> FsSiTabsiPbsList12 { get; set; }
        public virtual ICollection<FsZrosnPbsList> FsZrosnPbsList { get; set; }
        public virtual ICollection<FsZrstPbsList> FsZrstPbsList { get; set; }
    }
}
