using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsTab1T2List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R2 { get; set; }
        public string C2R2 { get; set; }
        public string C3R2 { get; set; }
        public decimal? C4R2 { get; set; }
        public string C5R2 { get; set; }
        public string C5bR2 { get; set; }
        public decimal? C6R2 { get; set; }
        public decimal? C7R2 { get; set; }
        public decimal? C8R2 { get; set; }

        public virtual HArpReport0503174 IdNavigation { get; set; }
    }
}
