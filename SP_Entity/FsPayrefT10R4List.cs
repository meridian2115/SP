using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPayrefT10R4List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R4N { get; set; }
        public string C2R4N { get; set; }
        public decimal? C3R4N { get; set; }
        public decimal? C4R4N { get; set; }
        public decimal? C5R4N { get; set; }
        public decimal? C6R4N { get; set; }

        public virtual DcArpReport05030742018 Doc { get; set; }
    }
}
