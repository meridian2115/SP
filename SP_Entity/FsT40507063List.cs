using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT40507063List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string T4C1 { get; set; }
        public string T4C2 { get; set; }
        public DateTime? T4C3 { get; set; }
        public decimal? T4C4 { get; set; }
        public decimal? T4C5 { get; set; }
        public decimal? T4C6 { get; set; }
        public decimal? T4C7 { get; set; }
        public decimal? T4C8 { get; set; }
        public decimal? T4C9 { get; set; }

        public virtual DcArpReport0507063 Doc { get; set; }
    }
}
