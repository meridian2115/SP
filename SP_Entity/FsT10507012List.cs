using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT10507012List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? S11 { get; set; }
        public decimal? S12 { get; set; }
        public decimal? S13 { get; set; }
        public string NumString { get; set; }
        public DateTime? Date1 { get; set; }
        public string Recipient { get; set; }
        public string Nmber { get; set; }
        public string Cf { get; set; }
        public string Pointorder { get; set; }

        public virtual DcArpReport0507012 Doc { get; set; }
    }
}
