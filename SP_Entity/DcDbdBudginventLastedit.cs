﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdBudginventLastedit
    {
        public DcDbdBudginventLastedit()
        {
            FsBacBac050LeList = new HashSet<FsBacBac050LeList>();
            FsBasBas050LeList = new HashSet<FsBasBas050LeList>();
            FsLaAgreer050LeList = new HashSet<FsLaAgreer050LeList>();
            FsLaAprove050LeList = new HashSet<FsLaAprove050LeList>();
            FsLaExecut050LeList = new HashSet<FsLaExecut050LeList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfDoctype { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfSecrecy { get; set; }
        public string InfBudgetCode { get; set; }
        public string InfBudgetName { get; set; }
        public string InfNamefo { get; set; }
        public string InfItemlist { get; set; }
        public string InfCircmf { get; set; }
        public string InfOkud { get; set; }
        public string InfUnitOkei { get; set; }
        public string InfUnitName { get; set; }
        public DateTime? InfDateofacc { get; set; }
        public string InfNote { get; set; }
        public DateTime? InfDateregfk { get; set; }
        public DateTime? InfDateoper { get; set; }
        public string InfPerioddbdPfrom { get; set; }
        public string InfPerioddbdPto { get; set; }
        public string InfSource { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDocdate { get; set; }
        public string InfRegnumb { get; set; }
        public DateTime? InfDatereceipt { get; set; }
        public DateTime? InfDocdatemf { get; set; }
        public string InfTofkName { get; set; }
        public string InfTofkCode { get; set; }
        public DateTime? InfDttmcrt { get; set; }
        public string InfSigninfo { get; set; }
        public string InfNamesigninfo { get; set; }
        public string InfChangecode { get; set; }
        public string InfChangename { get; set; }
        public DateTime? InfControlBaLbo { get; set; }
        public string InfBudgetcontrol { get; set; }
        public DateTime? InfSignlowcontrol { get; set; }
        public string InfBasislowcontrol { get; set; }
        public decimal? BacTsyYear { get; set; }
        public decimal? BacTsyYear1 { get; set; }
        public decimal? BacTsyYear2 { get; set; }
        public decimal? BacTsyzYear { get; set; }
        public decimal? BacTsyzYear1 { get; set; }
        public decimal? BacTsyzYear2 { get; set; }
        public decimal? BacTsydYear { get; set; }
        public decimal? BacTsydYear1 { get; set; }
        public decimal? BacTsydYear2 { get; set; }
        public decimal? BasTsyYear { get; set; }
        public decimal? BasTsyYear1 { get; set; }
        public decimal? BasTsyYear2 { get; set; }
        public decimal? BasTsyzYear { get; set; }
        public decimal? BasTsyzYear1 { get; set; }
        public decimal? BasTsyzYear2 { get; set; }
        public decimal? BasTsydYear { get; set; }
        public decimal? BasTsydYear1 { get; set; }
        public decimal? BasTsydYear2 { get; set; }
        public string SgnSgnmf { get; set; }
        public DateTime? SgnDatesignmf { get; set; }
        public DateTime? SgnDatesign { get; set; }
        public string SgnSgnfkSgnexct { get; set; }
        public string SgnSgnfkPstexct { get; set; }
        public string SgnSgnfkPhn { get; set; }
        public string SiLampgroupftas { get; set; }
        public string SiLampgroupfk { get; set; }
        public string SiLampgrouppuio { get; set; }
        public string SiLampgrouptn { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public string SiCirctechsign { get; set; }
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
        public string SiProtocolguid { get; set; }
        public DateTime? SiProtocoldate { get; set; }
        public string SiProtocolnum { get; set; }
        public bool? LaSkipappr { get; set; }
        public decimal? LaAmountrowexecutor { get; set; }
        public decimal? LaAmountrowagreer { get; set; }
        public decimal? LaAmountrowapprover { get; set; }
        public bool? InfChangefs { get; set; }
        public string Reporttitle { get; set; }
        public string BacTsyyeartxt { get; set; }
        public string BacTsyyear1txt { get; set; }
        public string BacTsyyear2txt { get; set; }
        public string InfTypedoc { get; set; }
        public DateTime? InfPerioddocfrom { get; set; }
        public DateTime? InfPerioddocto { get; set; }
        public string InfAppdatecomment { get; set; }

        public virtual ICollection<FsBacBac050LeList> FsBacBac050LeList { get; set; }
        public virtual ICollection<FsBasBas050LeList> FsBasBas050LeList { get; set; }
        public virtual ICollection<FsLaAgreer050LeList> FsLaAgreer050LeList { get; set; }
        public virtual ICollection<FsLaAprove050LeList> FsLaAprove050LeList { get; set; }
        public virtual ICollection<FsLaExecut050LeList> FsLaExecut050LeList { get; set; }
    }
}
