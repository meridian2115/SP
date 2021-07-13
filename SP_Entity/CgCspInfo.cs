using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgCspInfo
    {
        public decimal Id { get; set; }
        public string ProviderJclass { get; set; }
        public decimal SignAlgorithmId { get; set; }
        public decimal HashAlgorithmId { get; set; }
        public decimal CipherAlgorithmId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsWin32 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string InitParams { get; set; }
        public decimal Version { get; set; }
    }
}
