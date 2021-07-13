using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgCertInfo
    {
        public decimal Id { get; set; }
        public string Fingerprint { get; set; }
        public bool? Is4encrypt { get; set; }
        public bool? Is4sign { get; set; }
        public string Name { get; set; }
        public DateTime? RevokedDate { get; set; }
        public bool? IsTemp { get; set; }
        public string PrevCertFingerprint { get; set; }
        public DateTime StartValidDate { get; set; }
        public DateTime EndValidDate { get; set; }
        public bool? Is4data { get; set; }
        public string SubjectKeyIdentifier { get; set; }
        public bool? HasPrivatekeyLink { get; set; }
        public decimal Version { get; set; }
        public string AuthorizationUsage { get; set; }
        public byte[] CertBytes { get; set; }
        public string UserinfoName { get; set; }
    }
}
