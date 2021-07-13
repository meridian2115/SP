using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QueueSearchIndex
    {
        public decimal Id { get; set; }
        public string Guid { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Status { get; set; }
        public string GroupGuid { get; set; }
    }
}
