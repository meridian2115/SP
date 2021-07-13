using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsLinkdocacclsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string DocType { get; set; }
        public string DocTypeName { get; set; }
        public string ExtNumber { get; set; }
        public DateTime? ExtDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string RegNumber { get; set; }
        public DateTime? RegDate { get; set; }
        public string DocGroup { get; set; }
        public string DocGuid { get; set; }
        public string FlagPurEb { get; set; }

        public virtual DcArpReportAccls Doc { get; set; }
    }
}
