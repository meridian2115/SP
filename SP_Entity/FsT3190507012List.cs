using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT3190507012List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? S3 { get; set; }
        public decimal? S4 { get; set; }
        public decimal? S5 { get; set; }
        public string NumString { get; set; }
        public string ActName { get; set; }
        public string GrbsName { get; set; }
        public string Glava { get; set; }

        public virtual DcArpReport0507012 Doc { get; set; }
    }
}
