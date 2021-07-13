using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAdebtTable0201List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R020 { get; set; }
        public string C2R020 { get; set; }
        public string C3R020 { get; set; }
        public decimal? C4R020 { get; set; }
        public decimal? C5R020 { get; set; }
        public decimal? C6R020 { get; set; }
        public decimal? C7R020 { get; set; }
        public decimal? C8R020 { get; set; }
        public decimal? C9R020 { get; set; }
        public decimal? C10R020 { get; set; }
        public decimal? C11R020 { get; set; }
        public decimal? C12R020 { get; set; }
        public decimal? C13R020 { get; set; }

        public virtual HArpReport0503253 IdNavigation { get; set; }
    }
}
