using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFoR8300List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R3001 { get; set; }
        public string C2R3001 { get; set; }
        public decimal? C4R3001 { get; set; }
        public decimal? C5R3001 { get; set; }

        public virtual DcReport0503117 Doc { get; set; }
    }
}
