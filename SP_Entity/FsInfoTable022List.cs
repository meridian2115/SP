using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoTable022List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C3R022 { get; set; }
        public decimal? C4R022 { get; set; }
        public string C5R022 { get; set; }
        public string C3aR0221 { get; set; }
        public string C3bR0221 { get; set; }
        public string C3cR0221 { get; set; }
        public string C3dR0221 { get; set; }
        public string C3eR0221 { get; set; }

        public virtual DcReport0503177 Doc { get; set; }
    }
}
