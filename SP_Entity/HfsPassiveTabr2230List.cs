using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsPassiveTabr2230List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public decimal? C3 { get; set; }
        public decimal? C4 { get; set; }
        public decimal? C5 { get; set; }
        public decimal? C6 { get; set; }
        public decimal? C7 { get; set; }
        public decimal? C8 { get; set; }

        public virtual HArpReport0503230D IdNavigation { get; set; }
    }
}
