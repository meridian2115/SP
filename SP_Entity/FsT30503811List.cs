using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT30503811List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R031 { get; set; }
        public string C2R031 { get; set; }
        public string C3R031 { get; set; }
        public string C4R031 { get; set; }
        public string C5R031 { get; set; }
        public string C6R031 { get; set; }
        public string C7R031 { get; set; }
        public decimal? C8R031 { get; set; }
        public string KbkR031 { get; set; }

        public virtual DcArpReport0503811 Doc { get; set; }
    }
}
