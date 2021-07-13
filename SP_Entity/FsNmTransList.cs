using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsNmTransList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R41 { get; set; }
        public string C3R41 { get; set; }
        public decimal? C4R41 { get; set; }
        public decimal? C5R41 { get; set; }
        public string C6R41 { get; set; }
        public string C3aR41 { get; set; }
        public string C3bR41 { get; set; }
        public string C3cR41 { get; set; }
        public string C3dR41 { get; set; }
        public string C3eR41 { get; set; }
        public string PlanAccR4 { get; set; }

        public virtual DcArpreport0503725 Doc { get; set; }
    }
}
