using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDocBase
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? OrgCode { get; set; }
        public decimal? OrgVisibility { get; set; }
        public bool? Enabledflag { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Num { get; set; }
        public DateTime? DocDate { get; set; }
        public string Ubp { get; set; }
    }
}
