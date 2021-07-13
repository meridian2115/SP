using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabprint604List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string PrintT01 { get; set; }
        public string PrintT02 { get; set; }
        public string PrintT03 { get; set; }
        public string PrintT04 { get; set; }
        public string PrintT05 { get; set; }
        public string PrintT06 { get; set; }
        public decimal? PrintT07 { get; set; }
        public decimal? PrintT08 { get; set; }
        public decimal? PrintT09 { get; set; }
        public decimal? PrintT10 { get; set; }
        public decimal? PrintT11 { get; set; }
        public string NumString { get; set; }
        public string TypeString { get; set; }
        public string PrintKbk { get; set; }

        public virtual DcArpReport0506604 Doc { get; set; }
    }
}
