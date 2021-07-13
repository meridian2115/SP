using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdTreasuryNotice
    {
        public DcDbdTreasuryNotice()
        {
            FsBaBa721List = new HashSet<FsBaBa721List>();
            FsLaAppAgreerList = new HashSet<FsLaAppAgreerList>();
            FsLaApproveListList = new HashSet<FsLaApproveListList>();
            FsLaExecutorListList = new HashSet<FsLaExecutorListList>();
            FsLboLbo721List = new HashSet<FsLboLbo721List>();
            FsPofrPofr721List = new HashSet<FsPofrPofr721List>();
            FsSiPuioAccrecords1List = new HashSet<FsSiPuioAccrecords1List>();
            FsSiPuioAccrecordsList = new HashSet<FsSiPuioAccrecordsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfSecrecy { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfDoctype { get; set; }
        public string InfParentdoctype { get; set; }
        public string InfParentsystype { get; set; }
        public string InfParentdocname { get; set; }
        public string InfParentdocnumb { get; set; }
        public DateTime? InfParentdocdate { get; set; }
        public string InfNamefo { get; set; }
        public string InfItemlist { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfOkud { get; set; }
        public string InfNumbfk { get; set; }
        public DateTime? InfDateform { get; set; }
        public DateTime? InfDateregfk { get; set; }
        public DateTime? InfDateent { get; set; }
        public string InfFromTofkName { get; set; }
        public string InfFromTofkCode { get; set; }
        public string InfGrbsname { get; set; }
        public string InfGrbscode { get; set; }
        public string InfToTofkName { get; set; }
        public string InfToTofkCode { get; set; }
        public string InfNumbls { get; set; }
        public string InfSpecinstname { get; set; }
        public string InfSpecinstcode { get; set; }
        public string InfPerioddbdPfrom { get; set; }
        public string InfPerioddbdPto { get; set; }
        public string InfSource { get; set; }
        public string InfCircmf { get; set; }
        public string InfRegnumb { get; set; }
        public DateTime? InfDateoper { get; set; }
        public string InfGuidprnt { get; set; }
        public string InfMonthnum { get; set; }
        public DateTime? InfDttmcrt { get; set; }
        public DateTime? InfDateofacc { get; set; }
        public decimal? BaTsyYear { get; set; }
        public decimal? BaTsyYear1 { get; set; }
        public decimal? BaTsyYear2 { get; set; }
        public decimal? LboTsyYear { get; set; }
        public decimal? LboTsyYear1 { get; set; }
        public decimal? LboTsyYear2 { get; set; }
        public decimal? PofrTsyYear { get; set; }
        public DateTime? SgnDatesignfk { get; set; }
        public DateTime? SgnDatesignheadfk { get; set; }
        public string SgnSgnhrkfSgnexct { get; set; }
        public string SgnSgnhrkfPstexct { get; set; }
        public string SgnSgnhrkfPhn { get; set; }
        public string SgnSgnchffkSgnexct { get; set; }
        public string SgnSgnchffkPstexct { get; set; }
        public string SgnSgnchffkPhn { get; set; }
        public string SgnSignSgnexct { get; set; }
        public string SgnSignPstexct { get; set; }
        public string SgnSignPhn { get; set; }
        public string SgnApproverSfp { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfDocstate { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public string SiCirctechsign { get; set; }
        public string SiGrbssysname { get; set; }
        public DateTime? DtfkControldatetofk { get; set; }
        public string DtfkControlflagtofk { get; set; }
        public string SiPuioNmaccrec { get; set; }
        public string SiPuioNmaccrec1 { get; set; }
        public string SiSrtSerialnumber { get; set; }
        public DateTime? SiSrtStartdate { get; set; }
        public DateTime? SiSrtEnddate { get; set; }
        public DateTime? SiSrtSigndate { get; set; }
        public string SiSrtSignerfio { get; set; }
        public string SiIsexecuted { get; set; }
        public string SiTfTransferstatebp { get; set; }
        public string SiFlagregister { get; set; }
        public DateTime? SiDateofrevision { get; set; }
        public DateTime? SiDeferreddate { get; set; }
        public string SiTfTransferstatepfhd { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }
        public string InfKbktype { get; set; }
        public string InfGuidfk { get; set; }
        public DateTime? InfDatezku { get; set; }
        public decimal? BaTsydYear { get; set; }
        public decimal? BaTsydYear1 { get; set; }
        public decimal? BaTsydYear2 { get; set; }
        public decimal? LboTsydYear { get; set; }
        public decimal? LboTsydYear1 { get; set; }
        public decimal? LboTsydYear2 { get; set; }
        public decimal? PofrTsydYear { get; set; }
        public string Fullkbktype { get; set; }

        public virtual ICollection<FsBaBa721List> FsBaBa721List { get; set; }
        public virtual ICollection<FsLaAppAgreerList> FsLaAppAgreerList { get; set; }
        public virtual ICollection<FsLaApproveListList> FsLaApproveListList { get; set; }
        public virtual ICollection<FsLaExecutorListList> FsLaExecutorListList { get; set; }
        public virtual ICollection<FsLboLbo721List> FsLboLbo721List { get; set; }
        public virtual ICollection<FsPofrPofr721List> FsPofrPofr721List { get; set; }
        public virtual ICollection<FsSiPuioAccrecords1List> FsSiPuioAccrecords1List { get; set; }
        public virtual ICollection<FsSiPuioAccrecordsList> FsSiPuioAccrecordsList { get; set; }
    }
}
