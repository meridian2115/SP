using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Substitution
    {
        public long Id { get; set; }
        public long FromEmployeeId { get; set; }
        public long ToEmployeeId { get; set; }
        public DateTime? ActFrom { get; set; }
        public DateTime? ActTo { get; set; }
        public short State { get; set; }
    }
}
