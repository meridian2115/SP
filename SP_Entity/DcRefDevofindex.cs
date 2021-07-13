using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefDevofindex
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NatClassUnitsCodeunit { get; set; }
        public string NatClassUnitsNameunit { get; set; }
        public decimal? Devofind { get; set; }
        public decimal? Devofind2 { get; set; }
        public string Sign { get; set; }
        public string Signinv { get; set; }
        public string Note { get; set; }
        public string ReportFormsFormcode { get; set; }
        public string ReportFormsFormokud { get; set; }
        public string ReportFormsFormname { get; set; }
        public string ReportRprtprdcd { get; set; }
        public string ReportRprtprdnm { get; set; }
        public string ReportRprtprdtp { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
