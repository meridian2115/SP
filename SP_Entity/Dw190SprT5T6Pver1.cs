using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dw190SprT5T6Pver1
    {
        public Guid Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? ReportDate { get; set; }
        public short? PeriodType { get; set; }
        public string SvrCode { get; set; }
        public string ProgrCode { get; set; }
        public string ProgrType { get; set; }
        public decimal? FzUtv { get; set; }
        public decimal? FzIzm { get; set; }
        public decimal? Spr { get; set; }
        public bool? IsPozitive { get; set; }
        public decimal? SbrIzm { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
