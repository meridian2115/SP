using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgSignScheme
    {
        public decimal Id { get; set; }
        public decimal DocTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public bool Active { get; set; }
        public decimal Version { get; set; }
        public string Guid { get; set; }
        public bool Distributed { get; set; }
        public byte[] Conditions { get; set; }
        public decimal PatternVersion { get; set; }
        public decimal SchemeVersion { get; set; }
        public byte[] RawContent { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartDateDefault { get; set; }
    }
}
