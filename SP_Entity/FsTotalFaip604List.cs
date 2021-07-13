using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTotalFaip604List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1T02 { get; set; }
        public string C1T03 { get; set; }
        public decimal? C1T07 { get; set; }
        public decimal? C1T08 { get; set; }
        public decimal? C1T09 { get; set; }
        public decimal? C1T10 { get; set; }
        public decimal? C1T11 { get; set; }

        public virtual DcArpReport0506604 Doc { get; set; }
    }
}
