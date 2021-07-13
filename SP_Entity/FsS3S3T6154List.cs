using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS3S3T6154List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Innm { get; set; }
        public string Lncd0200 { get; set; }
        public string Glcd0200 { get; set; }
        public string Accd { get; set; }
        public decimal? Start0200 { get; set; }
        public decimal? End0200 { get; set; }
        public string Grbscd0200 { get; set; }
        public string Typeacc { get; set; }
        public string Cdsvr { get; set; }

        public virtual DcReport0503154 Doc { get; set; }
    }
}
