using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC1T1723List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R1 { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public decimal? S3 { get; set; }
        public decimal? S4 { get; set; }

        public virtual DcArpReport0503723 Doc { get; set; }
    }
}
