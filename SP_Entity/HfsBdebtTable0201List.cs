using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsBdebtTable0201List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R020 { get; set; }
        public string C2R020 { get; set; }
        public string C3R020 { get; set; }
        public decimal? C4R020 { get; set; }

        public virtual HArpReport0503253 IdNavigation { get; set; }
    }
}
