using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TSecurityFields
    {
        public decimal Id { get; set; }
        public decimal? ShipmentId { get; set; }
        public string DocFieldPath { get; set; }
        public string DocFieldType { get; set; }
        public string DocFieldValue { get; set; }
    }
}
