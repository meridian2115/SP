using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoTable012List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C3R012 { get; set; }
        public decimal? C4R012 { get; set; }
        public string C5R012 { get; set; }
        public string C3aR0121 { get; set; }
        public string C3bR0121 { get; set; }
        public string C3cR0121 { get; set; }
        public string C3dR0121 { get; set; }
        public string C3eR0121 { get; set; }

        public virtual DcReport0503177 Doc { get; set; }
    }
}
