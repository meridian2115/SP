using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReportTicket
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Creationdatetime { get; set; }
        public string CdSender { get; set; }
        public string CdRecipient { get; set; }
        public string NmFile { get; set; }
        public string GuidTransmittedDoc { get; set; }
        public string CdDelivery { get; set; }
        public string ErrorMessage { get; set; }
        public string AddInfo { get; set; }
    }
}
