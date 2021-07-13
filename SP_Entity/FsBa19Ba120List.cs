using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBa19Ba120List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1Ba { get; set; }
        public string C2Ba { get; set; }
        public decimal? C4Ba { get; set; }
        public decimal? C5Ba { get; set; }
        public string S { get; set; }

        public virtual DcArpReport0503120 Doc { get; set; }
    }
}
