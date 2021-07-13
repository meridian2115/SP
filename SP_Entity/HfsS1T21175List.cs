using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsS1T21175List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1aR2 { get; set; }
        public string C1bR2 { get; set; }
        public string С1сnR2 { get; set; }
        public string C1cR2 { get; set; }
        public string C1dR2 { get; set; }
        public string C1eR2 { get; set; }
        public decimal? C2R2 { get; set; }
        public DateTime? C3R2 { get; set; }
        public DateTime? C4R2 { get; set; }
        public string C5R2 { get; set; }
        public string C6R2 { get; set; }
        public string C7R2 { get; set; }
        public string C8R2 { get; set; }
        public string PlanAccR2 { get; set; }

        public virtual HReport0503175 IdNavigation { get; set; }
    }
}
