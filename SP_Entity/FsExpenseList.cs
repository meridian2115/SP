using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsExpenseList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1S1 { get; set; }
        public string C2S1 { get; set; }
        public string C3S1 { get; set; }
        public decimal? C4S1 { get; set; }
        public decimal? C5S1 { get; set; }
        public decimal? C5S2 { get; set; }
        public string C6S1 { get; set; }
        public string C6aS1 { get; set; }
        public string C6bS1 { get; set; }

        public virtual DcReport0503166 Doc { get; set; }
    }
}
