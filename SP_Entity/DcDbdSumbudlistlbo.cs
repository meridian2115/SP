using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdSumbudlistlbo
    {
        public DcDbdSumbudlistlbo()
        {
            FsBaBa051List = new HashSet<FsBaBa051List>();
            FsBasBas051List = new HashSet<FsBasBas051List>();
            FsBbaBa051List = new HashSet<FsBbaBa051List>();
            FsBlboBlbo051List = new HashSet<FsBlboBlbo051List>();
            FsLaAgreer051List = new HashSet<FsLaAgreer051List>();
            FsLaApprove051List = new HashSet<FsLaApprove051List>();
            FsLaExecutor051List = new HashSet<FsLaExecutor051List>();
            FsLboLbo051List = new HashSet<FsLboLbo051List>();
            FsUbasUba051List = new HashSet<FsUbasUba051List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfDoctype { get; set; }
        public DateTime? InfDatemf { get; set; }
        public string InfNumbmf { get; set; }
        public string InfOkud { get; set; }
        public string InfCircmf { get; set; }
        public string InfSecrecy { get; set; }
        public string InfNamefo { get; set; }
        public string InfItemlist { get; set; }
        public string InfAddinf { get; set; }
        public string InfSource { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfChangesCode { get; set; }
        public string InfChangesName { get; set; }
        public string InfChangesBasis { get; set; }
        public DateTime? InfDttmcrt { get; set; }
        public DateTime? InfDateregfk { get; set; }
        public DateTime? InfDatepostfk { get; set; }
        public string InfPerioddbdPfrom { get; set; }
        public string InfPerioddbdPto { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDocdate { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfRegnumb { get; set; }
        public string InfSpecinstname { get; set; }
        public string InfSpecinstcode { get; set; }
        public DateTime? InfDateoper { get; set; }
        public DateTime? InfDateofacc { get; set; }
        public DateTime? InfAccperstart { get; set; }
        public DateTime? InfAccperend { get; set; }
        public DateTime? InfDateapp { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public DateTime? InfControlBaLbo { get; set; }
        public string InfSigninfo { get; set; }
        public string InfNamesigninfo { get; set; }
        public string InfBudgetcontrol { get; set; }
        public DateTime? InfSignlowcontrol { get; set; }
        public string InfBasislowcontrol { get; set; }
        public string InfNote { get; set; }
        public decimal? BaTsyYear { get; set; }
        public decimal? BaTsyYear1 { get; set; }
        public decimal? BaTsyYear2 { get; set; }
        public decimal? BaTsyzYear { get; set; }
        public decimal? BaTsyzYear1 { get; set; }
        public decimal? BaTsyzYear2 { get; set; }
        public decimal? BaTsydYear { get; set; }
        public decimal? BaTsydYear1 { get; set; }
        public decimal? BaTsydYear2 { get; set; }
        public decimal? LboTsyYear { get; set; }
        public decimal? LboTsyYear1 { get; set; }
        public decimal? LboTsyYear2 { get; set; }
        public decimal? LboTsyzYear { get; set; }
        public decimal? LboTsyzYear1 { get; set; }
        public decimal? LboTsyzYear2 { get; set; }
        public decimal? LboTsydYear { get; set; }
        public decimal? LboTsydYear1 { get; set; }
        public decimal? LboTsydYear2 { get; set; }
        public decimal? BasTsyYear { get; set; }
        public decimal? BasTsyYear1 { get; set; }
        public decimal? BasTsyYear2 { get; set; }
        public decimal? BasTsyzYear { get; set; }
        public decimal? BasTsyzYear1 { get; set; }
        public decimal? BasTsyzYear2 { get; set; }
        public decimal? BasTsydYear { get; set; }
        public decimal? BasTsydYear1 { get; set; }
        public decimal? BasTsydYear2 { get; set; }
        public string SgnSignmf { get; set; }
        public DateTime? SgnDatesignmf { get; set; }
        public DateTime? SgnDatesign { get; set; }
        public string SgnSgnfkSgnexct { get; set; }
        public string SgnSgnfkPstexct { get; set; }
        public string SgnSgnfkPhn { get; set; }
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
        public string SiLampgrouptn { get; set; }
        public string SiLampgroupregtn { get; set; }
        public string SiAllowExceedingLbo { get; set; }
        public DateTime? DtfkControldatetofk { get; set; }
        public string DtfkControlflagtofk { get; set; }
        public string SiPuioNmaccrec { get; set; }
        public string SiPuioNmaccrec1 { get; set; }
        public string SiSrtSerialnumber { get; set; }
        public DateTime? SiSrtStartdate { get; set; }
        public DateTime? SiSrtEnddate { get; set; }
        public DateTime? SiSrtSigndate { get; set; }
        public string SiSrtSignerfio { get; set; }
        public string SiGuiddocblock { get; set; }
        public string SiProtocolguid { get; set; }
        public DateTime? SiProtocoldate { get; set; }
        public string SiProtocolnum { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }
        public decimal? UbaTsyDYear { get; set; }
        public decimal? UbaTsyDYear1 { get; set; }
        public decimal? UbaTsyDYear2 { get; set; }
        public decimal? UbaTsyDuYear { get; set; }
        public decimal? UbaTsyDuYear1 { get; set; }
        public decimal? UbaTsyDuYear2 { get; set; }
        public decimal? UlboTsyDYear { get; set; }
        public decimal? UlboTsyDYear1 { get; set; }
        public decimal? UlboTsyDYear2 { get; set; }
        public decimal? UlboTsyDuYear { get; set; }
        public decimal? UlboTsyDuYear1 { get; set; }
        public decimal? UlboTsyDuYear2 { get; set; }
        public decimal? UbasTsyDYear { get; set; }
        public decimal? UbasTsyDYear1 { get; set; }
        public decimal? UbasTsyDYear2 { get; set; }
        public decimal? UbasTsyDuYear { get; set; }
        public decimal? UbasTsyDuYear1 { get; set; }
        public decimal? UbasTsyDuYear2 { get; set; }

        public virtual ICollection<FsBaBa051List> FsBaBa051List { get; set; }
        public virtual ICollection<FsBasBas051List> FsBasBas051List { get; set; }
        public virtual ICollection<FsBbaBa051List> FsBbaBa051List { get; set; }
        public virtual ICollection<FsBlboBlbo051List> FsBlboBlbo051List { get; set; }
        public virtual ICollection<FsLaAgreer051List> FsLaAgreer051List { get; set; }
        public virtual ICollection<FsLaApprove051List> FsLaApprove051List { get; set; }
        public virtual ICollection<FsLaExecutor051List> FsLaExecutor051List { get; set; }
        public virtual ICollection<FsLboLbo051List> FsLboLbo051List { get; set; }
        public virtual ICollection<FsUbasUba051List> FsUbasUba051List { get; set; }
    }
}
