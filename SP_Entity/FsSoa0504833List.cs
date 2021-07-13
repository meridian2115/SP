using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSoa0504833List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Guid { get; set; }
        public string Status { get; set; }
        public string Inst { get; set; }
        public string Statuspur { get; set; }
        public bool? Checkb { get; set; }

        public virtual DcArpSoa0504833 Doc { get; set; }
    }
}
