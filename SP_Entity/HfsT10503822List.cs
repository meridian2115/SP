using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsT10503822List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R011 { get; set; }
        public string C2R011 { get; set; }
        public string C3R011 { get; set; }
        public string C4R011 { get; set; }
        public string C5R011 { get; set; }
        public string C6R011 { get; set; }

        public virtual HArpReport0503822 IdNavigation { get; set; }
    }
}
