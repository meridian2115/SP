using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArrReportKvitok
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string HrStatuscode { get; set; }
        public DateTime? HrCreationdatetime { get; set; }
        public string HrSendersubjcode { get; set; }
        public string HrSendsyscode { get; set; }
        public string HrReceivsyscode { get; set; }
        public string HrGuidcreateddocument { get; set; }
        public string HrSendstatuscode { get; set; }
        public string HrErrormessage { get; set; }
        public string HrInformation { get; set; }
        public string AsfkTofkcode { get; set; }
        public string AsfkFksegmentcode { get; set; }
        public string AsfkFksystem { get; set; }
        public string AsfkAsfkdocguid { get; set; }
        public string AsfkEbdocguid { get; set; }
        public string AsfkInformation { get; set; }
        public string AksiokTofkcode { get; set; }
        public string AksiokEbdocguid { get; set; }
        public string AksiokAksdocguid { get; set; }
        public string AksiokInformation { get; set; }
        public string Keyfield { get; set; }
    }
}
