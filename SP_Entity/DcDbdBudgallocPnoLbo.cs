using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdBudgallocPnoLbo
    {
        public DcDbdBudgallocPnoLbo()
        {
            FsLaAgreer054List = new HashSet<FsLaAgreer054List>();
            FsLaApprove054List = new HashSet<FsLaApprove054List>();
            FsLaExecutor054List = new HashSet<FsLaExecutor054List>();
            FsLboLbo054List = new HashSet<FsLboLbo054List>();
            FsPnoPno054List = new HashSet<FsPnoPno054List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfDoctype { get; set; }
        public DateTime? InfDocdate { get; set; }
        public string InfSecrecy { get; set; }
        public string InfNamefo { get; set; }
        public string InfCircmf { get; set; }
        public string InfSource { get; set; }
        public string InfOkud { get; set; }
        public DateTime? InfDttmcrt { get; set; }
        public DateTime? InfDateregfk { get; set; }
        public string InfRegnumb { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public string InfPerioddbdPfrom { get; set; }
        public string InfPerioddbdPto { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDatepostfk { get; set; }
        public DateTime? InfDateent { get; set; }
        public DateTime? InfDateoper { get; set; }
        public DateTime? InfDateofacc { get; set; }
        public string InfAddinf { get; set; }
        public bool? InfHideintrows { get; set; }
        public DateTime? InfDocdatemf { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public string InfRevdocguid { get; set; }
        public string InfSigninfo { get; set; }
        public string InfNamesigninfo { get; set; }
        public string InfChangecode { get; set; }
        public string InfChangename { get; set; }
        public string InfBudgetcontrol { get; set; }
        public DateTime? InfSignlowcontrol { get; set; }
        public string InfBasislowcontrol { get; set; }
        public decimal? PnoTsyYear { get; set; }
        public decimal? PnoTsyYear1 { get; set; }
        public decimal? PnoTsyYear2 { get; set; }
        public decimal? PnoTsyrYear { get; set; }
        public decimal? PnoTsyrYear1 { get; set; }
        public decimal? PnoTsyrYear2 { get; set; }
        public decimal? PnoTsyzYear { get; set; }
        public decimal? PnoTsyzYear1 { get; set; }
        public decimal? PnoTsyzYear2 { get; set; }
        public decimal? PnoTsydYear { get; set; }
        public decimal? PnoTsydYear1 { get; set; }
        public decimal? PnoTsydYear2 { get; set; }
        public decimal? LboTsyYear { get; set; }
        public decimal? LboTsyYear1 { get; set; }
        public decimal? LboTsyYear2 { get; set; }
        public decimal? LboTsyrYear { get; set; }
        public decimal? LboTsyrYear1 { get; set; }
        public decimal? LboTsyrYear2 { get; set; }
        public decimal? LboTsyzYear { get; set; }
        public decimal? LboTsyzYear1 { get; set; }
        public decimal? LboTsyzYear2 { get; set; }
        public decimal? LboTsydYear { get; set; }
        public decimal? LboTsydYear1 { get; set; }
        public decimal? LboTsydYear2 { get; set; }
        public string SgnSgnfkSgnexct { get; set; }
        public string SgnSgnfkPstexct { get; set; }
        public string SgnSgnfkPhn { get; set; }
        public string SgnSgnmfSgnexct { get; set; }
        public string SgnSgnmfPstexct { get; set; }
        public string SgnSgnmfPhn { get; set; }
        public DateTime? SgnDatesignmf { get; set; }
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
        public DateTime? SiRecalldate { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }

        public virtual ICollection<FsLaAgreer054List> FsLaAgreer054List { get; set; }
        public virtual ICollection<FsLaApprove054List> FsLaApprove054List { get; set; }
        public virtual ICollection<FsLaExecutor054List> FsLaExecutor054List { get; set; }
        public virtual ICollection<FsLboLbo054List> FsLboLbo054List { get; set; }
        public virtual ICollection<FsPnoPno054List> FsPnoPno054List { get; set; }
    }
}
