using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsSfIncreaseList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R7101 { get; set; }
        public string C2R7101 { get; set; }
        public string C3R7101 { get; set; }
        public string C3aR7101 { get; set; }
        public string C3bR7101 { get; set; }
        public decimal? C4R7101 { get; set; }
        public decimal? C6R7101 { get; set; }
        public decimal? C7R7101 { get; set; }
        public decimal? C8R7101 { get; set; }

        public virtual HReport0503127 IdNavigation { get; set; }
    }
}
