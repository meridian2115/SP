using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAgFb117R7010List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R0101 { get; set; }
        public string C2R0101 { get; set; }
        public string C3R0101 { get; set; }
        public decimal? C4R0101 { get; set; }
        public decimal? C5R0101 { get; set; }

        public virtual HReport0503117Fb IdNavigation { get; set; }
    }
}
