using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpKvit1c
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Creationdatetime { get; set; }
        public string Sendersubjcode { get; set; }
        public string CdSender { get; set; }
        public string CdRecipient { get; set; }
        public string Message { get; set; }
        public string Statuscode { get; set; }
        public string HdrTofkcode { get; set; }
        public string HdrFksegmentcode { get; set; }
        public string HdrFksystem { get; set; }
        public string HdrAsfkdocguid { get; set; }
        public string HdrEbdocguid { get; set; }
        public string HdrInformation { get; set; }
    }
}
