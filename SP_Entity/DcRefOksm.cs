using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefOksm
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Numbercode { get; set; }
        public string Shortname { get; set; }
        public string Fullname { get; set; }
        public string Codealfa2 { get; set; }
        public string Codealfa3 { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Guidnsi { get; set; }
    }
}
