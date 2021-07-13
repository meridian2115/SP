using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwRepOperInfoExpFbS1
    {
        public Guid? DocUuid { get; set; }
        public string EklName { get; set; }
        public string EklVed { get; set; }
        public string EklFkr { get; set; }
        public string EklCsr { get; set; }
        public string EklVr { get; set; }
        public decimal? FinYear { get; set; }
        public DateTime? DateOt { get; set; }
        public decimal? SummaUtv { get; set; }
        public decimal? SummaSbr { get; set; }
        public decimal? SummaKas { get; set; }
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
    }
}
