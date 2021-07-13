using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DoccontentCancdoc
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Addinfoid { get; set; }
        public decimal? Addinfo2id { get; set; }
        public decimal? Organizationid { get; set; }
        public decimal? Senderid { get; set; }
        public decimal? Receiverid { get; set; }
        public string Cancdocid { get; set; }
        public string Cancreason { get; set; }
        public string Statetransfer { get; set; }
        public string Stateconfirm { get; set; }
        public string Pbscode { get; set; }
        public string Grbscode { get; set; }
        public string Simpnum { get; set; }
        public string Currpbs { get; set; }
        public string Regnumber { get; set; }
    }
}
