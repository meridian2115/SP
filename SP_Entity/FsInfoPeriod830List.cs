using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoPeriod830List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R2301 { get; set; }
        public decimal? C4R2301 { get; set; }
        public decimal? C5R2301 { get; set; }
        public decimal? C6R2301 { get; set; }
        public decimal? C7R2301 { get; set; }
        public decimal? C8R2301 { get; set; }
        public decimal? C9R2301 { get; set; }
        public decimal? C10R2301 { get; set; }
        public decimal? C11R2301 { get; set; }

        public virtual DcArprep0503830 Doc { get; set; }
    }
}
