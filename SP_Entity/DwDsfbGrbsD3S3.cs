using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwDsfbGrbsD3S3
    {
        public string NomDocPolPofSkv { get; set; }
        public DateTime? DateDocPolPofSkv { get; set; }
        public decimal? SumIzmPofPolSk { get; set; }
        public decimal? SumIzmPofPolV { get; set; }
        public decimal DocId { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public Guid DocUuid { get; set; }
        public decimal? IdMapingFormList { get; set; }
    }
}
