using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsActiveR30503773List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR3 { get; set; }
        public string C1bR3 { get; set; }
        public string C1cR3 { get; set; }
        public decimal? C2R3 { get; set; }
        public string C3R3 { get; set; }
        public string C4aR3 { get; set; }
        public string C4bR3 { get; set; }
        public string C5aR3 { get; set; }
        public string C5bR3 { get; set; }

        public virtual DcArpReport05037732019 Doc { get; set; }
    }
}
