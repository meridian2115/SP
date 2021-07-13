using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsT40503372List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R041 { get; set; }
        public string C2R041 { get; set; }
        public decimal? C3R041 { get; set; }
        public decimal? C4R041 { get; set; }
        public DateTime? C5R041 { get; set; }
        public string LncdR041 { get; set; }

        public virtual HArpReport0503372 IdNavigation { get; set; }
    }
}
