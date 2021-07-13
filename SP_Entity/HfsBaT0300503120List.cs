using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsBaT0300503120List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C2R2101 { get; set; }
        public string C3R0301 { get; set; }
        public decimal? C4R2101 { get; set; }
        public decimal? C5R2101 { get; set; }
        public string Tabcounter030 { get; set; }

        public virtual HArpReport0503120 IdNavigation { get; set; }
    }
}
