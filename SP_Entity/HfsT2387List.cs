using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsT2387List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public decimal? C14R2 { get; set; }
        public decimal? C25R2 { get; set; }
        public decimal? C26R2 { get; set; }
        public decimal? C31R2 { get; set; }
        public decimal? C33R2 { get; set; }
        public decimal? C34R2 { get; set; }

        public virtual HArpReport0503387 IdNavigation { get; set; }
    }
}
