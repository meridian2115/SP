using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpNotification
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Periodicity { get; set; }
        public string Periodicity2 { get; set; }
        public string Period { get; set; }
        public string PrOktmo { get; set; }
        public string PrGlavaBk { get; set; }
        public string PrInstitutionCode { get; set; }
        public string Dd { get; set; }
        public string Mm { get; set; }
        public string Yyyy { get; set; }
        public string SubNm { get; set; }
        public bool? IsZagranOrg { get; set; }
        public string Nmsubjreport { get; set; }
        public string Signerfio { get; set; }
        public string Serialnumber { get; set; }
        public DateTime? Signdate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
    }
}
