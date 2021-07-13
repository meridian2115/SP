using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TaskHistory
    {
        public decimal Id { get; set; }
        public DateTime Created { get; set; }
        public decimal Userid { get; set; }
        public byte[] Data { get; set; }
    }
}
