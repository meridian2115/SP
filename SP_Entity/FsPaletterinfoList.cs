using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPaletterinfoList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? Datemess { get; set; }
        public string Numbermess { get; set; }
        public string Authnumbermess { get; set; }
        public DateTime? Authdatemess { get; set; }

        public virtual DcRefPersaccount Doc { get; set; }
    }
}
