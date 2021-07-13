using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcOktmo
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Section { get; set; }
        public string Code { get; set; }
        public string Control { get; set; }
        public string Name { get; set; }
        public string AdditionalData { get; set; }
        public string LinkSrFederalDistrict { get; set; }
        public string LinkSrSubjectRf { get; set; }
        public string PrOktmoPrCode { get; set; }
        public string PrOktmoPrName { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Guidnsi { get; set; }
        public string CodeSubjectRf { get; set; }
    }
}
