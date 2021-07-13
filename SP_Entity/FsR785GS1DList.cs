using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR785GS1DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS1DC1 { get; set; }
        public decimal? GS1DC2 { get; set; }
        public decimal? GS1DC3 { get; set; }
        public decimal? GS1DC4 { get; set; }
        public decimal? GS1DC5 { get; set; }
        public decimal? GS1DC6 { get; set; }
        public decimal? GS1DC7 { get; set; }
        public decimal? GS1DC8 { get; set; }
        public decimal? GS1DC9 { get; set; }
        public decimal? GS1DC10 { get; set; }
        public string GS1DC11 { get; set; }
        public string Secrecy { get; set; }

        public virtual DcVlsReport0531785 Doc { get; set; }
    }
}
