using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class PendingNotifications
    {
        public decimal Id { get; set; }
        public DateTime Created { get; set; }
        public byte[] Notification { get; set; }
    }
}
