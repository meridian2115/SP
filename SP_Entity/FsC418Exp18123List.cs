using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC418Exp18123List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name9001 { get; set; }
        public string Kosgu9001 { get; set; }
        public string Cdsubsec9001 { get; set; }
        public string Kvr9001 { get; set; }
        public decimal? Sum9001 { get; set; }
        public string Strcode9001 { get; set; }

        public virtual DcArpReport0503123 Doc { get; set; }
    }
}
