using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dw0503125
    {
        public Guid? Uuid { get; set; }
        public int? Year { get; set; }
        public DateTime? DateOt { get; set; }
        public short? PeriodType { get; set; }
        public string VedCode { get; set; }
        public string PrpCode { get; set; }
        public string SbuCode { get; set; }
        public short? TypeStr { get; set; }
        public string Name { get; set; }
        public string KontrInn { get; set; }
        public string Ppp { get; set; }
        public string Oktmo { get; set; }
        public string ElemBudg { get; set; }
        public string Schet { get; set; }
        public decimal? Debet { get; set; }
        public decimal? Credit { get; set; }
        public string KorSchet { get; set; }
        public string KorrInn { get; set; }
        public string KorrPpp { get; set; }
        public string KorrOktmo { get; set; }
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
