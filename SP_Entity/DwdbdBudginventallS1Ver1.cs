using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwdbdBudginventallS1Ver1
    {
        public Guid Uuid { get; set; }
        public int? InfPlperiodYear { get; set; }
        public int? InfPlperiodYear1 { get; set; }
        public int? InfPlperiodYear2 { get; set; }
        public DateTime? InfDocdate { get; set; }
        public DateTime? InfDocdatemf { get; set; }
        public DateTime? HrReportDate { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string InfDocnumber { get; set; }
        public string InfChangecode { get; set; }
        public string InfChangename { get; set; }
        public string InfNote { get; set; }
        public string InfDoctype { get; set; }
        public string Nameindicat { get; set; }
        public string Grbscode { get; set; }
        public string BdcodeSection { get; set; }
        public string BdcodeSubsection { get; set; }
        public string SectionSubsection { get; set; }
        public string BdcodeTarget { get; set; }
        public string BdcodeExp { get; set; }
        public string Kbk { get; set; }
        public string Signkbk { get; set; }
        public string Fullkbktype { get; set; }
        public decimal? SyYear { get; set; }
        public decimal? SyYear1 { get; set; }
        public decimal? SyYear2 { get; set; }
        public short? IsTotal { get; set; }
        public decimal? DisplaySum { get; set; }
        public string DateString { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
