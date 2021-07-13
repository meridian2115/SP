using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT3125GvfList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineNum { get; set; }
        public decimal? Dat1 { get; set; }
        public decimal? Dat2 { get; set; }
        public decimal? Dat3 { get; set; }

        public virtual DcRpPrt0503125Gvf Doc { get; set; }
    }
}
