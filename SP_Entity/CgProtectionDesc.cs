using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgProtectionDesc
    {
        public decimal Id { get; set; }
        public decimal? CipherAlgorithmId { get; set; }
        public decimal? HashAlgorithmId { get; set; }
        public string Type { get; set; }
        public string KeyPattern { get; set; }
        public bool? InsetFlag { get; set; }
        public decimal? InsetLength { get; set; }
        public byte[] InsetMask { get; set; }
        public DateTime ChangeDate { get; set; }
        public bool Active { get; set; }
        public decimal Version { get; set; }
    }
}
