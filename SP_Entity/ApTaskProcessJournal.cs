using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class ApTaskProcessJournal
    {
        public decimal Id { get; set; }
        public string TaskName { get; set; }
        public DateTime StartTime { get; set; }
        public decimal? ElapsedTime { get; set; }
        public string ProcessStatus { get; set; }
        public string Message { get; set; }
        public string TaskGuid { get; set; }
        public decimal? TaskId { get; set; }
    }
}
