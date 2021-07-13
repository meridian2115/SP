using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwDsfbGrbsDopPof3S7
    {
        public decimal DocId { get; set; }
        public decimal FnlId { get; set; }
        public string Grbs { get; set; }
        public string Fkr { get; set; }
        public string Csr { get; set; }
        public string Vr { get; set; }
        public string Kosgu { get; set; }
        public decimal? PrSumIzmPofVPol { get; set; }
        public decimal? PrSumIzmPofVRas { get; set; }
        public decimal? PrSumIzmPofVOst { get; set; }
        public string PrNotePofV { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public Guid DocUuid { get; set; }
        public decimal? IdMapingFormList { get; set; }
    }
}
