using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAnalytica169List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1aR02030 { get; set; }
        public string C1bR02030 { get; set; }
        public string C1cR02030 { get; set; }
        public string C1dR02030 { get; set; }
        public string C1eR02030 { get; set; }
        public decimal? C2R02030 { get; set; }
        public DateTime? C4R02030 { get; set; }
        public string C5R02030 { get; set; }
        public string C6R02030 { get; set; }
        public string C7R02030 { get; set; }
        public string C8R02030 { get; set; }

        public virtual HReport0503169 IdNavigation { get; set; }
    }
}
