using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsHGScrDList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2 { get; set; }
        public string C8 { get; set; }
        public decimal? C10 { get; set; }

        public virtual DcArpFah0504071 Doc { get; set; }
    }
}
