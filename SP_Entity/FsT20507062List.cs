using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT20507062List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T2Num { get; set; }
        public string T2C1 { get; set; }
        public string T2C2 { get; set; }
        public DateTime? T2C3 { get; set; }
        public decimal? T2C4 { get; set; }
        public decimal? T2C5 { get; set; }
        public decimal? T2C6 { get; set; }
        public decimal? T2C7 { get; set; }
        public decimal? T2C8 { get; set; }
        public decimal? T2C9 { get; set; }

        public virtual DcRpReport0507062 Doc { get; set; }
    }
}
