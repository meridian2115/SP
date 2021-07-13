using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcTypeSubjReport
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string CodepSr { get; set; }
    }
}
