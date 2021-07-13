using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgUserProfile
    {
        public decimal Id { get; set; }
        public decimal? ArchAlgorithmId { get; set; }
        public decimal? ChecksumAlgorithmId { get; set; }
        public decimal UserinfoId { get; set; }
        public string ProtectionLevel { get; set; }
        public string UsercertFingerprint { get; set; }
        public decimal? ProtectDescMinId { get; set; }
        public decimal? ProtectDescAvId { get; set; }
        public decimal Version { get; set; }
        public string FormalizedTitle { get; set; }
        public string Name { get; set; }
        public string UserinfoSystemname { get; set; }
    }
}
