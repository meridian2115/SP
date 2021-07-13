using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAcAicostP775List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R031 { get; set; }
        public string C1aR031 { get; set; }
        public string C1bR031 { get; set; }
        public string C1cR031 { get; set; }
        public string C1dR031 { get; set; }
        public decimal? C2R031 { get; set; }
        public decimal? C3R031 { get; set; }
        public decimal? C4R031 { get; set; }
        public DateTime? C5R031 { get; set; }
        public DateTime? C6R031 { get; set; }
        public string C7R031 { get; set; }
        public string C8R031 { get; set; }
        public string TypeString { get; set; }
        public string NumString { get; set; }

        public virtual DcReport0503775 Doc { get; set; }
    }
}
