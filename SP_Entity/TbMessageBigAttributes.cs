using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TbMessageBigAttributes
    {
        public decimal TbMsgId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public string Description { get; set; }
        public byte[] Body { get; set; }
        public decimal? OrdinalNumber { get; set; }
        public string DocGuid { get; set; }
        public decimal Id { get; set; }
        public string AttGuid { get; set; }
        public DateTime? PreparedDate { get; set; }
        public byte[] DigitalSignatures { get; set; }
    }
}
