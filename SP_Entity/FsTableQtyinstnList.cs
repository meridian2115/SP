using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTableQtyinstnList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Lookupexpenspartcode { get; set; }
        public string ExpenspartcodeV { get; set; }
        public decimal? C2R1 { get; set; }
        public decimal? C3R1 { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public decimal? C7R1 { get; set; }
        public decimal? C8R1 { get; set; }
        public decimal? C9R1 { get; set; }
        public decimal? C10R1 { get; set; }
        public decimal? C11R1 { get; set; }
        public decimal? C12R1 { get; set; }
        public decimal? C13R1 { get; set; }
        public decimal? C14R1 { get; set; }
        public decimal? C15R1 { get; set; }
        public string C16R1 { get; set; }

        public virtual DcReport0503161 Doc { get; set; }
    }
}
