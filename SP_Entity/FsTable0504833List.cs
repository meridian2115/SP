using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTable0504833List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameOperation { get; set; }
        public string NumDocBase { get; set; }
        public DateTime? DateDocBase { get; set; }
        public string AccountNumDebit { get; set; }
        public string AccountNumLoan { get; set; }
        public decimal? Amount { get; set; }

        public virtual DcReport0504833 Doc { get; set; }
    }
}
