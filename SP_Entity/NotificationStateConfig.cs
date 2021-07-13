using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class NotificationStateConfig
    {
        public decimal Id { get; set; }
        public string Uuiddoc { get; set; }
        public decimal? Docid { get; set; }
        public string NotifyMode { get; set; }
        public string States { get; set; }
        public DateTime Created { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
