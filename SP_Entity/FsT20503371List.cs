using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT20503371List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cd { get; set; }
        public string Cd1 { get; set; }
        public string Cd2 { get; set; }
        public string Cd3 { get; set; }
        public string Cd4 { get; set; }
        public string Cd5 { get; set; }
        public string Cd6 { get; set; }
        public decimal? Sum1 { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Cd7 { get; set; }
        public string NumString { get; set; }
        public string C1b1R01030 { get; set; }
        public string C1b2R01030 { get; set; }
        public string C1b3R01030 { get; set; }

        public virtual DcArpReport0503371 Doc { get; set; }
    }
}
