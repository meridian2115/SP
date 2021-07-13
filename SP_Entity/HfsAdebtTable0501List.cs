using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAdebtTable0501List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R050 { get; set; }
        public string C2R050 { get; set; }
        public string C3R050 { get; set; }
        public decimal? C4R050 { get; set; }
        public decimal? C5R050 { get; set; }
        public decimal? C6R050 { get; set; }
        public decimal? C7R050 { get; set; }
        public decimal? C8R050 { get; set; }
        public decimal? C9R050 { get; set; }
        public decimal? C10R050 { get; set; }
        public decimal? C11R050 { get; set; }
        public decimal? C12R050 { get; set; }
        public decimal? C13R050 { get; set; }

        public virtual HArpReport0503253 IdNavigation { get; set; }
    }
}
