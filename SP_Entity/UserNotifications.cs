using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class UserNotifications
    {
        public string Guid { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string NotificationType { get; set; }
        public string Doctype { get; set; }
        public string Docguid { get; set; }
    }
}
