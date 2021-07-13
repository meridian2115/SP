using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR759GS24DList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string GS24DC1 { get; set; }
        public DateTime? GS24DC2 { get; set; }
        public string GS24DC3 { get; set; }
        public DateTime? GS24DC4 { get; set; }
        public string GS24DC5 { get; set; }
        public string GS24DC6 { get; set; }
        public decimal? GS24DC7 { get; set; }
        public string GS24DC8 { get; set; }
        public string GS24DDocHGuid { get; set; }
        public string GS24DDocLGuid { get; set; }

        public virtual DcVlsReport0531759 Doc { get; set; }
    }
}
