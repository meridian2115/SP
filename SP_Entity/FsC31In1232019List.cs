using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC31In1232019List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name8101 { get; set; }
        public string Kosgu8101 { get; set; }
        public string Cdsubsec8101 { get; set; }
        public string C4aR8101 { get; set; }
        public string C4bR8101 { get; set; }
        public decimal? Sum8101 { get; set; }
        public string Strcode8101 { get; set; }

        public virtual DcArpReport05031232019 Doc { get; set; }
    }
}
