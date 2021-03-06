using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFederalDistricts
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public string Center { get; set; }
        public string Note { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Cdfo { get; set; }
    }
}
