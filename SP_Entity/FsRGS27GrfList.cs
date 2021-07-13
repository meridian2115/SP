using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRGS27GrfList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS27GrfC3 { get; set; }
        public decimal? GS27GrfR8 { get; set; }
        public decimal? GS27GrfR9 { get; set; }
        public decimal? GS27GrfR10 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
