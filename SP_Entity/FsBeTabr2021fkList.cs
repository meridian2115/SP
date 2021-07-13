using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBeTabr2021fkList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R2001 { get; set; }
        public string C2R2001 { get; set; }
        public decimal? C3R2001 { get; set; }
        public decimal? C4R2001 { get; set; }
        public decimal? C5R2001 { get; set; }
        public decimal? C6R2001 { get; set; }
        public decimal? C7R2001 { get; set; }
        public decimal? C8R2001 { get; set; }
        public decimal? C9R2001 { get; set; }
        public string Marker200 { get; set; }

        public virtual DcArpReport0507021Fk Doc { get; set; }
    }
}
