using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class SecSbemployee
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long? BusinessroleId { get; set; }
        public long ConfidentialityLevelId { get; set; }
    }
}
