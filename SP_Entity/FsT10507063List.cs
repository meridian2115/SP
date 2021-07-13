using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT10507063List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T1C1 { get; set; }
        public string T1C2 { get; set; }
        public DateTime? T1C3 { get; set; }
        public decimal? T1C4 { get; set; }
        public decimal? T1C5 { get; set; }
        public decimal? T1C6 { get; set; }

        public virtual DcArpReport0507063 Doc { get; set; }
    }
}
