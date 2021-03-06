using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAeAieconP775List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R041 { get; set; }
        public string C1aR041 { get; set; }
        public string C1bR041 { get; set; }
        public string C1cR041 { get; set; }
        public string C1dR041 { get; set; }
        public decimal? C2R041 { get; set; }
        public decimal? C3R041 { get; set; }
        public decimal? C4R041 { get; set; }
        public string TypeString { get; set; }
        public string NumString { get; set; }

        public virtual DcReport0503775 Doc { get; set; }
    }
}
