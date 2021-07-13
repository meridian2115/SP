using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwDsfbGrbsD2S3
    {
        public string NomDocPolSkv { get; set; }
        public DateTime? DateDocPolSkv { get; set; }
        public decimal? SumIzmLboPolSk { get; set; }
        public decimal? SumIzmLboPolV { get; set; }
        public decimal DocId { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public Guid DocUuid { get; set; }
        public decimal? IdMapingFormList { get; set; }
    }
}
