using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC4Expense123List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name900 { get; set; }
        public string Kosgu900 { get; set; }
        public string Cdsubsec900 { get; set; }
        public decimal? Sum900 { get; set; }
        public string Strcode900 { get; set; }

        public virtual DcArpReport0503123 Doc { get; set; }
    }
}
