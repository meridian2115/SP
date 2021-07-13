using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR3005List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cdchapter { get; set; }
        public string Nmsubjreport { get; set; }
        public string CdSr { get; set; }
        public string Fullname { get; set; }
        public string Cdtpsub { get; set; }
        public string Nmklassanddicts { get; set; }
        public string Indexcode { get; set; }
        public string Commentuser { get; set; }

        public virtual DcArpReport000005 Doc { get; set; }
    }
}
