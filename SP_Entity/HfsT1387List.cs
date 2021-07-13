using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsT1387List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public decimal? C14R1 { get; set; }
        public decimal? C25R1 { get; set; }
        public decimal? C26R1 { get; set; }
        public decimal? C31R1 { get; set; }
        public decimal? C33R1 { get; set; }
        public decimal? C34R1 { get; set; }

        public virtual HArpReport0503387 IdNavigation { get; set; }
    }
}
