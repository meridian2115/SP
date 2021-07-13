using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTsR4950List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R951 { get; set; }
        public string C2R951 { get; set; }
        public string C3R951 { get; set; }
        public decimal? C4R9511 { get; set; }
        public decimal? C5R9511 { get; set; }
        public decimal? C6R9511 { get; set; }
        public decimal? C7R9511 { get; set; }
        public decimal? C8R9511 { get; set; }

        public virtual DcArpReport0503737 Doc { get; set; }
    }
}
