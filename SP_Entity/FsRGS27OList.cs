using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRGS27OList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS27OC5 { get; set; }
        public decimal? GS27OR6 { get; set; }
        public decimal? GS27OR8 { get; set; }
        public decimal? GS27OR9 { get; set; }
        public decimal? GS27OR10 { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
