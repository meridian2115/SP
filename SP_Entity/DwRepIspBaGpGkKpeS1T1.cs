using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwRepIspBaGpGkKpeS1T1
    {
        public Guid? DocUuid { get; set; }
        public string IdFact { get; set; }
        public decimal? FinYear { get; set; }
        public DateTime? ReportDate { get; set; }
        public string GpCode { get; set; }
        public string GpName { get; set; }
        public string VedCode { get; set; }
        public decimal? Zac { get; set; }
        public decimal? Rosp { get; set; }
        public decimal? Isp { get; set; }
        public decimal? IspZak { get; set; }
        public decimal? IspRosp { get; set; }
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
