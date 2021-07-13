using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC31Out1232019List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name8201 { get; set; }
        public string Kosgu8201 { get; set; }
        public string Cdsubsec8201 { get; set; }
        public string C4aR8201 { get; set; }
        public string C4bR8201 { get; set; }
        public decimal? Sum8201 { get; set; }
        public string Strcode8201 { get; set; }

        public virtual DcArpReport05031232019 Doc { get; set; }
    }
}
