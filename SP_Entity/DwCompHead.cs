using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwCompHead
    {
        public string NumRef { get; set; }
        public DateTime DateOt { get; set; }
        public DateTime? DateReg { get; set; }
        public DateTime? DateOtChar { get; set; }
        public decimal? GapReg { get; set; }
        public string VidIzm { get; set; }
        public decimal? GapUtv { get; set; }
        public string FkrCode { get; set; }
        public string FkrName { get; set; }
        public string VedCode { get; set; }
        public string VedName { get; set; }
        public decimal TypeRef { get; set; }
        public decimal FinYear { get; set; }
        public decimal IdFact { get; set; }
        public decimal? IsTotal { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? IdMapingFormList { get; set; }
        public Guid? DocUuid { get; set; }
    }
}
