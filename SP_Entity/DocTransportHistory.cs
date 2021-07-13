using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DocTransportHistory
    {
        public decimal Id { get; set; }
        public decimal DocId { get; set; }
        public decimal Ordinal { get; set; }
        public DateTime RecordTime { get; set; }
        public string ComplexGlobId { get; set; }
        public string OrgSysName { get; set; }
        public string Meta { get; set; }
        public string ComplexName { get; set; }
        public string OrgName { get; set; }
        public string EventType { get; set; }
    }
}
