using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoId230List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C3R1201 { get; set; }
        public string C4R1201 { get; set; }
        public decimal? C5R1201 { get; set; }
        public decimal? Tabcounter4 { get; set; }
        public string Tabcounter3 { get; set; }

        public virtual HArpReport0503230D IdNavigation { get; set; }
    }
}
