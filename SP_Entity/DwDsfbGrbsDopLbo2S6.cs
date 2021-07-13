using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwDsfbGrbsDopLbo2S6
    {
        public decimal DocId { get; set; }
        public decimal FnlId { get; set; }
        public string Grbs { get; set; }
        public string Fkr { get; set; }
        public string Csr { get; set; }
        public string Vr { get; set; }
        public string Kosgu { get; set; }
        public decimal? PrSumIzmLboSkPol { get; set; }
        public decimal? PrSumIzmLboSkRas { get; set; }
        public decimal? PrSumIzmLboSkOst { get; set; }
        public string PrNoteLboSk { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public Guid DocUuid { get; set; }
        public decimal? IdMapingFormList { get; set; }
    }
}
