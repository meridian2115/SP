using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRaRevenuList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R011 { get; set; }
        public string C2R011 { get; set; }
        public decimal? C3R011 { get; set; }
        public string C2aR011 { get; set; }
        public string C2bR011 { get; set; }
        public string C2cR011 { get; set; }
        public string C2dR011 { get; set; }
        public string C2eR011 { get; set; }

        public virtual DcArpO0504072 Doc { get; set; }
    }
}
