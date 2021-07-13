using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRGS23GrfList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS23GrfC4 { get; set; }
        public decimal? GS23GrfR5 { get; set; }
        public decimal? GS23GrfR7 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
