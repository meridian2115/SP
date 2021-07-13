using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TbMessage
    {
        public decimal Id { get; set; }
        public decimal SysFromCode { get; set; }
        public decimal SysToCode { get; set; }
        public decimal Priority { get; set; }
        public string QueueName { get; set; }
        public DateTime TimeCreate { get; set; }
        public DateTime TimeAccept { get; set; }
        public DateTime TimeFinish { get; set; }
        public string TypeMessage { get; set; }
        public string DescMessage { get; set; }
        public decimal Status { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public byte[] Xml { get; set; }
        public DateTime? TimeLastProcessed { get; set; }
        public decimal ProcessedCount { get; set; }
    }
}
