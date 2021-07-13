using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TbEvent
    {
        public decimal EventId { get; set; }
        public string EventCode { get; set; }
        public DateTime EventTime { get; set; }
        public string ErrorMsg { get; set; }
        public string DocGuid { get; set; }
        public string DocGroup { get; set; }
        public string DocType { get; set; }
        public string RNumber { get; set; }
        public DateTime? RDate { get; set; }
        public string ENumber { get; set; }
        public DateTime? EDate { get; set; }
        public decimal? MsgId { get; set; }
        public string MsgType { get; set; }
        public string MessageStatus { get; set; }
        public decimal? TbMsgId { get; set; }
        public string Bodid { get; set; }
        public string SufdDocGuid { get; set; }
        public string TransportDocGuid { get; set; }
        public string TransportId { get; set; }
        public string AddInfo { get; set; }
    }
}
