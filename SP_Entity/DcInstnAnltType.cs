using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcInstnAnltType
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code2 { get; set; }
        public string Anlttypename { get; set; }
        public string Dirname { get; set; }
        public DateTime? PrdFromDate { get; set; }
        public DateTime? PrdToDate { get; set; }
    }
}
