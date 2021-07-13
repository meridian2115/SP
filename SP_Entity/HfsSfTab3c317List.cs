using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsSfTab3c317List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R7101 { get; set; }
        public string C2R7101 { get; set; }
        public string C3R7101 { get; set; }
        public string C3aR7101 { get; set; }
        public string C3bR7101 { get; set; }

        public virtual HArpReport0503317 IdNavigation { get; set; }
    }
}
