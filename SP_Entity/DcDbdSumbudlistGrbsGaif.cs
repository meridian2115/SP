using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdSumbudlistGrbsGaif
    {
        public DcDbdSumbudlistGrbsGaif()
        {
            FsBacBa055List = new HashSet<FsBacBa055List>();
            FsBasSba055List = new HashSet<FsBasSba055List>();
            FsLaAgreer055List = new HashSet<FsLaAgreer055List>();
            FsLaApprove055List = new HashSet<FsLaApprove055List>();
            FsLaExecutor055List = new HashSet<FsLaExecutor055List>();
            FsLboLbo055List = new HashSet<FsLboLbo055List>();
            FsTchTba055List = new HashSet<FsTchTba055List>();
            FsTchTbas055List = new HashSet<FsTchTbas055List>();
            FsTchTlbo055List = new HashSet<FsTchTlbo055List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfExtregnumb { get; set; }
        public DateTime? InfDocdate { get; set; }
        public string InfGrbscode { get; set; }
        public string InfRegnumb { get; set; }
        public DateTime? InfDateregfk { get; set; }
        public string InfGrbsname { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfSecrecy { get; set; }
        public string InfCircmf { get; set; }
        public string InfInfcode { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfDoctype { get; set; }
        public string InfOkud { get; set; }
        public string InfSource { get; set; }
        public string InfDepmfCode { get; set; }
        public string InfDepmfName { get; set; }
        public string InfChangesCode { get; set; }
        public string InfChangesName { get; set; }
        public string InfChangesBasis { get; set; }
        public string InfQuestioncode { get; set; }
        public string InfQuestion { get; set; }
        public string InfAddinfocode { get; set; }
        public string InfAddinf { get; set; }
        public string InfNumbmf { get; set; }
        public DateTime? InfDatereg { get; set; }
        public DateTime? InfCanceldate { get; set; }
        public string InfControlsum { get; set; }
        public string InfItemlist { get; set; }
        public DateTime? InfDttmcrt { get; set; }
        public string InfPerioddbdPfrom { get; set; }
        public string InfPerioddbdPto { get; set; }
        public DateTime? InfDateoper { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public DateTime? InfCreatedate { get; set; }
        public DateTime? InfExtregdt { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDateofacc { get; set; }
        public string InfSigninfo { get; set; }
        public string InfNamesigninfo { get; set; }
        public string InfFundcontrol { get; set; }
        public DateTime? InfControlBaLbo { get; set; }
        public string InfBudgetcontrol { get; set; }
        public DateTime? InfSignlowcontrol { get; set; }
        public string InfBasislowcontrol { get; set; }
        public decimal? BacTsyYear { get; set; }
        public decimal? BacTsyYear1 { get; set; }
        public decimal? BacTsyYear2 { get; set; }
        public decimal? LboTsyYear { get; set; }
        public decimal? LboTsyYear1 { get; set; }
        public decimal? LboTsyYear2 { get; set; }
        public decimal? BasTsyYear { get; set; }
        public decimal? BasTsyYear1 { get; set; }
        public decimal? BasTsyYear2 { get; set; }
        public string SgnLeader { get; set; }
        public string SgnLeaderfn { get; set; }
        public DateTime? SgnHdDatesign { get; set; }
        public string SgnSigndep { get; set; }
        public string SgnSgnmfSgnexct { get; set; }
        public string SgnSgnmfPstexct { get; set; }
        public string SgnSgnmfPhn { get; set; }
        public string SgnSignou { get; set; }
        public string SgnSgnfkSgnexct { get; set; }
        public string SgnSgnfkPstexct { get; set; }
        public string SgnSgnfkPhn { get; set; }
        public DateTime? SgnFkDatesign { get; set; }
        public DateTime? SgnMfDatesign { get; set; }
        public string SiLampgroupftas { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public DateTime? DtfkControldatetofk { get; set; }
        public string DtfkControlflagtofk { get; set; }
        public string SiPuioNmaccrec { get; set; }
        public string SiPuioNmaccrec1 { get; set; }
        public string SiSrtSerialnumber { get; set; }
        public DateTime? SiSrtStartdate { get; set; }
        public DateTime? SiSrtEnddate { get; set; }
        public DateTime? SiSrtSigndate { get; set; }
        public string SiSrtSignerfio { get; set; }
        public string SiProtocolguid { get; set; }
        public DateTime? SiProtocoldate { get; set; }
        public string SiProtocolnum { get; set; }
        public string SiCheckpuioresult { get; set; }
        public string SiErrormessage { get; set; }
        public string SiErrorstack { get; set; }
        public string SiAllowExceedingLbo { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }

        public virtual ICollection<FsBacBa055List> FsBacBa055List { get; set; }
        public virtual ICollection<FsBasSba055List> FsBasSba055List { get; set; }
        public virtual ICollection<FsLaAgreer055List> FsLaAgreer055List { get; set; }
        public virtual ICollection<FsLaApprove055List> FsLaApprove055List { get; set; }
        public virtual ICollection<FsLaExecutor055List> FsLaExecutor055List { get; set; }
        public virtual ICollection<FsLboLbo055List> FsLboLbo055List { get; set; }
        public virtual ICollection<FsTchTba055List> FsTchTba055List { get; set; }
        public virtual ICollection<FsTchTbas055List> FsTchTbas055List { get; set; }
        public virtual ICollection<FsTchTlbo055List> FsTchTlbo055List { get; set; }
    }
}
