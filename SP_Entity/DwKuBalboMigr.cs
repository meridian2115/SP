using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwKuBalboMigr
    {
        public Guid? Uuid { get; set; }
        public decimal? DocId { get; set; }
        public int? Year { get; set; }
        public DateTime? DateZku { get; set; }
        public DateTime? DateVku { get; set; }
        public DateTime? DatePod { get; set; }
        public DateTime? DateF { get; set; }
        public string NomKu { get; set; }
        public string GlavaGrs { get; set; }
        public string Rzpr { get; set; }
        public string Csr { get; set; }
        public string Vr { get; set; }
        public decimal? Ba1 { get; set; }
        public decimal? Ba2 { get; set; }
        public decimal? Ba3 { get; set; }
        public decimal? Lbo1 { get; set; }
        public decimal? Lbo2 { get; set; }
        public decimal? Lbo3 { get; set; }
        public short? Accesslevel { get; set; }
        public decimal? YearR { get; set; }
    }
}
