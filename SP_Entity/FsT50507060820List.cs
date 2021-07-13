using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT50507060820List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R820t { get; set; }
        public string C2R820t { get; set; }
        public string C3R820t { get; set; }
        public string C4R820t { get; set; }
        public decimal? C5R820t { get; set; }

        public virtual DcArpReport0507060 Doc { get; set; }
    }
}
