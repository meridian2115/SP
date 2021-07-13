using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBaT1900503120List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R1901 { get; set; }
        public string C3R1901 { get; set; }
        public decimal? C4R01901 { get; set; }
        public decimal? C5R1901 { get; set; }
        public string Tabcounter190 { get; set; }

        public virtual DcArpReport0503120 Doc { get; set; }
    }
}
