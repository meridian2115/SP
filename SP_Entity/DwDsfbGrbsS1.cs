using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwDsfbGrbsS1
    {
        public string GlavaGrbs { get; set; }
        public decimal DocId { get; set; }
        public DateTime? DateOtch { get; set; }
        public DateTime? DateOld { get; set; }
        public decimal? SumBa1yBegin { get; set; }
        public decimal? SumBa1yEnd { get; set; }
        public decimal? SumLbo1yBegin { get; set; }
        public decimal? SumLbo1yEnd { get; set; }
        public string Ls { get; set; }
        public decimal? DocDbYear { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public Guid DocUuid { get; set; }
        public decimal? IdMapingFormList { get; set; }
    }
}
