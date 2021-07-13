using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgExservConnection
    {
        public decimal Id { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExtraParams { get; set; }
        public DateTime? LastDate { get; set; }
        public string LastErrorCode { get; set; }
        public string LastErrMess { get; set; }
        public string Status { get; set; }
        public decimal Version { get; set; }
        public string CaFingerprint { get; set; }
    }
}
