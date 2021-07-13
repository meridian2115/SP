using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwDsfbGrbsTitles
    {
        public decimal DocId { get; set; }
        public string Ls { get; set; }
        public string NameTofk { get; set; }
        public string KodTofk { get; set; }
        public string NameGrbs { get; set; }
        public string GlavaGrbs { get; set; }
        public DateTime? DateOtch { get; set; }
        public DateTime? DateOld { get; set; }
        public Guid DocUuid { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? IdMapingFormList { get; set; }
    }
}
