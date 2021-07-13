using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcMscExpendableschedule
    {
        public DcMscExpendableschedule()
        {
            FsApbastrList = new HashSet<FsApbastrList>();
            FsAplbostrList = new HashSet<FsAplbostrList>();
            FsAppofstrList = new HashSet<FsAppofstrList>();
            FsLaAgreer723List = new HashSet<FsLaAgreer723List>();
            FsLaApprove723List = new HashSet<FsLaApprove723List>();
            FsLaExecutor723List = new HashSet<FsLaExecutor723List>();
            FsLafkAgreer723List = new HashSet<FsLafkAgreer723List>();
            FsLafkApprove723List = new HashSet<FsLafkApprove723List>();
            FsLafkExecutor723List = new HashSet<FsLafkExecutor723List>();
            FsPofrbalanceinfoList = new HashSet<FsPofrbalanceinfoList>();
            FsSiTabsiList8 = new HashSet<FsSiTabsiList8>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Typerr { get; set; }
        public string Unit { get; set; }
        public string Guidrr { get; set; }
        public string Guidppp { get; set; }
        public string ApLampgroupftas { get; set; }
        public string ApLampgroupfk { get; set; }
        public string ApLampgrouppuio { get; set; }
        public string ApLampgroupchkr { get; set; }
        public string ApDoctype { get; set; }
        public string ApKfdform { get; set; }
        public string ApForokei { get; set; }
        public string ApGuidfkr { get; set; }
        public string ApApgrbsCode { get; set; }
        public string ApApgrbsUbpcode { get; set; }
        public string ApApgrbsName { get; set; }
        public string ApRbspbsaifdbCode { get; set; }
        public string ApRbspbsaifdbName { get; set; }
        public string ApAplsubp { get; set; }
        public string ApAptofkCode { get; set; }
        public string ApAptofkName { get; set; }
        public string ApCodebudg { get; set; }
        public string ApNamebud { get; set; }
        public string ApFoFinancialinst { get; set; }
        public string ApFoOkpocode { get; set; }
        public string ApApheadPosition { get; set; }
        public string ApApheadFullname { get; set; }
        public DateTime? ApDatesignrr { get; set; }
        public string ApRespexPosition { get; set; }
        public string ApRespexFullname { get; set; }
        public string ApRespexTelephone { get; set; }
        public DateTime? ApSigningdateisp { get; set; }
        public DateTime? ApDocdatebu { get; set; }
        public string ApBudgtype { get; set; }
        public string ApConsolidateregistercode { get; set; }
        public string ApLevelbudg { get; set; }
        public string ApSignsfilled { get; set; }
        public string ApSignsfilledrrr { get; set; }
        public string ApriGuid { get; set; }
        public DateTime? ApriCreationdate { get; set; }
        public string AprNumrr { get; set; }
        public DateTime? AprDocdateutv { get; set; }
        public string AprSecrecysign { get; set; }
        public string AprItemlist { get; set; }
        public string AprCode { get; set; }
        public string AprName { get; set; }
        public string AprAccountnumubp { get; set; }
        public string OfkCode { get; set; }
        public string OfkName { get; set; }
        public string SiSpecialinst { get; set; }
        public string SiCode { get; set; }
        public string KbkKbk { get; set; }
        public string KbkTargetcode { get; set; }
        public string KbkBktype { get; set; }
        public decimal? BaAmountcurryear { get; set; }
        public decimal? BaAmountfirstyear { get; set; }
        public decimal? BaAmountsecondyear { get; set; }
        public decimal? LboAmountcurryear { get; set; }
        public decimal? LboAmountfirstyear { get; set; }
        public decimal? LboAmountsecondyear { get; set; }
        public decimal? AprTotalamountpof1 { get; set; }
        public string AprRequestnum { get; set; }
        public DateTime? AprDocdatepp { get; set; }
        public DateTime? AprDocdateUtvBa { get; set; }
        public DateTime? AprDocdateutvlbo { get; set; }
        public DateTime? AprDocdateutvpof { get; set; }
        public string AprRecallreason { get; set; }
        public string AprSpecialinstosn { get; set; }
        public bool? AprAttrOrgtypecode { get; set; }
        public string AprBudgetarycntrl { get; set; }
        public DateTime? AprTransacreducedcntrl { get; set; }
        public string AprBaselowercntrl { get; set; }
        public string PsCode { get; set; }
        public string PsName { get; set; }
        public string UpCode { get; set; }
        public string UpName { get; set; }
        public string OrgTofkcode { get; set; }
        public string OrgNumbernegexpsch { get; set; }
        public DateTime? OrgDatenegexpsch { get; set; }
        public string SiRegisterinformaccguid { get; set; }
        public string SiRowidcode { get; set; }
        public string SiHeadidcode { get; set; }
        public string SiResultparam { get; set; }
        public string SiTextresultparam { get; set; }
        public string SiAccountnum { get; set; }
        public DateTime? SiExecutiondate { get; set; }
        public string SiRejectionreason { get; set; }
        public string SiRelevancesign { get; set; }
        public string SiTypeaccountnum { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public string SiProtocolguid { get; set; }
        public DateTime? SiProtocoldate { get; set; }
        public string SiProtocolnum { get; set; }
        public string SiTofkcodeasfk { get; set; }
        public string SiFlagsendtoasfk { get; set; }
        public string SiKofkcodecreator { get; set; }
        public string SiPorbscode { get; set; }
        public bool? SiSendtopur { get; set; }
        public string SiCheckpuioresult { get; set; }
        public DateTime? SiDocdateutvrrr { get; set; }
        public bool? SiAgreerSkipall { get; set; }
        public string SiSpecialinsttech { get; set; }
        public string SiOrgTypeP { get; set; }
        public string SiClientapprovername { get; set; }
        public string SiTofkapprovername { get; set; }
        public string SiNubpsign { get; set; }
        public DateTime? DtfkControldatetofk { get; set; }
        public string DtfkControlflagtofk { get; set; }
        public DateTime? SiDttmforcntrl { get; set; }
        public string SiCodetofk { get; set; }
        public string SiAgreelist { get; set; }
        public string SiApprovelist { get; set; }
        public string SiPuioNmaccrec { get; set; }
        public string SiPuioNmaccrec1 { get; set; }
        public string SiRecallguid { get; set; }
        public string SiBlocklboguid { get; set; }
        public string SrtSerialnumber { get; set; }
        public DateTime? SrtStartdate { get; set; }
        public DateTime? SrtEnddate { get; set; }
        public DateTime? SrtSigndate { get; set; }
        public string SrtSignerfio { get; set; }
        public DateTime? SiRecalldate { get; set; }
        public string SiRecallnum { get; set; }
        public DateTime? SiBlockdate { get; set; }
        public string SiBlocknum { get; set; }
        public DateTime? SiSuspensiondate { get; set; }
        public string SiSuspensionnum { get; set; }
        public string SiSuspensionguid { get; set; }
        public string SiRegistrynum { get; set; }
        public decimal? SiCounter { get; set; }
        public string SiRecalltofk { get; set; }
        public string SiDocsegmentcode { get; set; }
        public string SiTfTransferstatebp { get; set; }
        public string SiImporteddoc { get; set; }
        public string SiGuidcopydoc { get; set; }
        public string SiOrgtypecode { get; set; }
        public string SiTfTransfererrorbp { get; set; }
        public string SiTfTransferstatepfhd { get; set; }
        public string SiTfTransfererrorpfhd { get; set; }
        public string SiClosedcontour { get; set; }
        public string SiSigneqorg { get; set; }
        public string SiSigncheckpuio { get; set; }
        public DateTime? SiMaxdocdateutv { get; set; }
        public string SiNoticeunmarkdsp { get; set; }
        public string SiNoticeunmarkdspguid { get; set; }
        public string SiAccessleveltechfield { get; set; }
        public string FffSegmentCode { get; set; }
        public string FffScFlag { get; set; }
        public string FffScDir { get; set; }
        public string FffCheckRtoFlag { get; set; }
        public string FffChangeType { get; set; }
        public string FffBfaSTech { get; set; }
        public string FffPaBfaSTech { get; set; }
        public string FffPaFtS { get; set; }
        public string FffPaFtR { get; set; }
        public string FffBiRTech { get; set; }
        public DateTime? FffAttribute4DTech { get; set; }
        public string FffExtrattrb1 { get; set; }
        public string FffExtrattrb2 { get; set; }
        public string FffExtrattrb3 { get; set; }
        public string FffExtrattrb4 { get; set; }
        public string FffSendertofk { get; set; }
        public string FffRecipienttofk { get; set; }
        public string FffFlagSumInTransit { get; set; }
        public string FffSbrchangecode { get; set; }
        public string EaPeriodfrom { get; set; }
        public string EaPeriod { get; set; }
        public DateTime? EaRegdate1 { get; set; }
        public DateTime? EaRegdate2 { get; set; }
        public DateTime? EaDocdatefk1 { get; set; }
        public DateTime? EaDocdatefk2 { get; set; }
        public string EaSource { get; set; }
        public string EaRegnumr { get; set; }
        public DateTime? EaRegdater { get; set; }
        public string EaCircsystem { get; set; }
        public string EaAcceptindicator { get; set; }
        public string EaAuthorizedorg { get; set; }
        public string CkFkcodesvr { get; set; }
        public string CkFkcode { get; set; }
        public bool? CkInwork { get; set; }
        public string CkrFkcodesvr { get; set; }
        public string CkrFkcode { get; set; }
        public bool? CkrInwork { get; set; }
        public DateTime? EaReceiptdatetofk { get; set; }
        public string EaCircsender { get; set; }
        public string EaCircreciever { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }
        public bool? LafkSkipappr { get; set; }
        public decimal? LafkAmountrowexecutor { get; set; }
        public decimal? LafkAmountrowagreer { get; set; }
        public decimal? LafkAmountrowapprover { get; set; }
        public string Status { get; set; }
        public DateTime? DateEnrollment { get; set; }
        public DateTime? DateCancellation { get; set; }
        public DateTime? DateSigning { get; set; }

        public virtual ICollection<FsApbastrList> FsApbastrList { get; set; }
        public virtual ICollection<FsAplbostrList> FsAplbostrList { get; set; }
        public virtual ICollection<FsAppofstrList> FsAppofstrList { get; set; }
        public virtual ICollection<FsLaAgreer723List> FsLaAgreer723List { get; set; }
        public virtual ICollection<FsLaApprove723List> FsLaApprove723List { get; set; }
        public virtual ICollection<FsLaExecutor723List> FsLaExecutor723List { get; set; }
        public virtual ICollection<FsLafkAgreer723List> FsLafkAgreer723List { get; set; }
        public virtual ICollection<FsLafkApprove723List> FsLafkApprove723List { get; set; }
        public virtual ICollection<FsLafkExecutor723List> FsLafkExecutor723List { get; set; }
        public virtual ICollection<FsPofrbalanceinfoList> FsPofrbalanceinfoList { get; set; }
        public virtual ICollection<FsSiTabsiList8> FsSiTabsiList8 { get; set; }
    }
}
