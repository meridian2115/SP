using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsAhFb117R8600List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R6001 { get; set; }
        public string C2R6001 { get; set; }
        public decimal? C3R6001 { get; set; }
        public decimal? C4R6001 { get; set; }

        public virtual HReport0503117Fb IdNavigation { get; set; }
    }
}
