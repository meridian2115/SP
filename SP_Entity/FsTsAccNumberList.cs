using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTsAccNumberList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R2 { get; set; }
        public string C3R2 { get; set; }
        public string C4R2 { get; set; }
        public string C5R2 { get; set; }
        public string C6R2 { get; set; }
        public decimal? C7R2 { get; set; }
        public decimal? C8R2 { get; set; }
        public string C9R2 { get; set; }
        public string C101R2 { get; set; }
        public string C10R2 { get; set; }
        public string C11R2 { get; set; }
        public string NumR2 { get; set; }
        public string C6aR2 { get; set; }
        public string C6bR2 { get; set; }
        public string C6cR2 { get; set; }
        public string C6Kvd { get; set; }
        public string C6Kosgu { get; set; }
        public string C6Acc { get; set; }

        public virtual DcReport0503125 Doc { get; set; }
    }
}
