using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdDecchange
    {
        public DcDbdDecchange()
        {
            FsBacBacst066List = new HashSet<FsBacBacst066List>();
            FsBacTotalgrbsList = new HashSet<FsBacTotalgrbsList>();
            FsBasBasrc066List = new HashSet<FsBasBasrc066List>();
            FsBasBastg066List = new HashSet<FsBasBastg066List>();
            FsLaAgreer066List = new HashSet<FsLaAgreer066List>();
            FsLaApprove066List = new HashSet<FsLaApprove066List>();
            FsLaExecutor066List = new HashSet<FsLaExecutor066List>();
            FsLboLbo066List = new HashSet<FsLboLbo066List>();
            FsLboLbotg066List = new HashSet<FsLboLbotg066List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfDoctype { get; set; }
        public DateTime? InfDttmcrt { get; set; }
        public string InfOkud { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfNumbmf { get; set; }
        public DateTime? InfDateapp { get; set; }
        public string InfCircmf { get; set; }
        public string InfSecrecy { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public string InfNamefo { get; set; }
        public string InfItemlist { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDocdate { get; set; }
        public string InfRegnumb { get; set; }
        public DateTime? InfRegdate { get; set; }
        public DateTime? InfDateoper { get; set; }
        public string InfPerioddbdPfrom { get; set; }
        public string InfPerioddbdPto { get; set; }
        public DateTime? InfDateofacc { get; set; }
        public string InfSource { get; set; }
        public string InfGrbscode { get; set; }
        public DateTime? InfDateregfk { get; set; }
        public string InfSigninfo { get; set; }
        public string InfNamesigninfo { get; set; }
        public DateTime? InfControlBaLbo { get; set; }
        public string InfBudgetcontrol { get; set; }
        public DateTime? InfSignlowcontrol { get; set; }
        public string InfBasislowcontrol { get; set; }
        public decimal? BacTsyzYear { get; set; }
        public decimal? BacTsyzYear1 { get; set; }
        public decimal? BacTsyzYear2 { get; set; }
        public decimal? BacTsydYear { get; set; }
        public decimal? BacTsydYear1 { get; set; }
        public decimal? BacTsydYear2 { get; set; }
        public decimal? LboTsyzYear { get; set; }
        public decimal? LboTsyzYear1 { get; set; }
        public decimal? LboTsyzYear2 { get; set; }
        public decimal? LboTsydYear { get; set; }
        public decimal? LboTsydYear1 { get; set; }
        public decimal? LboTsydYear2 { get; set; }
        public decimal? BasTsyzYear { get; set; }
        public decimal? BasTsyzYear1 { get; set; }
        public decimal? BasTsyzYear2 { get; set; }
        public decimal? BasTsydYear { get; set; }
        public decimal? BasTsydYear1 { get; set; }
        public decimal? BasTsydYear2 { get; set; }
        public string SignSignmf { get; set; }
        public DateTime? SignDatesignmf { get; set; }
        public string SignSigndepmf { get; set; }
        public DateTime? SignDatesign { get; set; }
        public string SignSignSgnexct { get; set; }
        public string SignSignPstexct { get; set; }
        public string SignSignPhn { get; set; }
        public string SiLampgroupftas { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouptn { get; set; }
        public string SiLampgroupregtn { get; set; }
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
        public string SiAllowExceedingLbo { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }

        public virtual ICollection<FsBacBacst066List> FsBacBacst066List { get; set; }
        public virtual ICollection<FsBacTotalgrbsList> FsBacTotalgrbsList { get; set; }
        public virtual ICollection<FsBasBasrc066List> FsBasBasrc066List { get; set; }
        public virtual ICollection<FsBasBastg066List> FsBasBastg066List { get; set; }
        public virtual ICollection<FsLaAgreer066List> FsLaAgreer066List { get; set; }
        public virtual ICollection<FsLaApprove066List> FsLaApprove066List { get; set; }
        public virtual ICollection<FsLaExecutor066List> FsLaExecutor066List { get; set; }
        public virtual ICollection<FsLboLbo066List> FsLboLbo066List { get; set; }
        public virtual ICollection<FsLboLbotg066List> FsLboLbotg066List { get; set; }
    }
}
