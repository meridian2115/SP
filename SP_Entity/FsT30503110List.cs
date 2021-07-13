using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT30503110List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR03100 { get; set; }
        public string C1bR03100 { get; set; }
        public string C1cR03100 { get; set; }
        public string C1dR03100 { get; set; }
        public string C1eR03100 { get; set; }
        public string C1gR03100 { get; set; }
        public string C2R03100 { get; set; }
        public string C3R03100 { get; set; }
        public decimal? C4R03100 { get; set; }
        public decimal? C5R03100 { get; set; }

        public virtual DcReport0503110 Doc { get; set; }
    }
}
