using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsC4Expense723List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string Linecode900 { get; set; }
        public string Kosgu { get; set; }
        public string Cdsubsec { get; set; }
        public decimal? Sum { get; set; }
        public string Analyticcode1 { get; set; }
        public string Analyticcode2 { get; set; }

        public virtual DcArpReport0503723 Doc { get; set; }
    }
}
