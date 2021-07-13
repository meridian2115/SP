using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefProgramm
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Nn { get; set; }
        public string Nm { get; set; }
        public string Cd { get; set; }
        public string Ist { get; set; }
        public string Target { get; set; }
        public string Direction { get; set; }
        public DateTime? Dt { get; set; }
        public string RecipientsNm { get; set; }
        public string EpCode { get; set; }
        public string EpName { get; set; }
        public string KbkCd { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Note { get; set; }
        public DateTime? AgreementDate { get; set; }
    }
}
