using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class LogAi
    {
        public decimal? LogId { get; set; }
        public decimal? StepId { get; set; }
        public decimal? UserId { get; set; }
        public DateTime? LogDate { get; set; }
        public string Pkg { get; set; }
        public string Exec { get; set; }
        public string EventType { get; set; }
        public string Message { get; set; }
        public DateTime? LogTime { get; set; }
        public decimal? DbSid { get; set; }
    }
}
