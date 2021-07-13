using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QrtzFiredTriggers
    {
        public string SchedName { get; set; }
        public string EntryId { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string InstanceName { get; set; }
        public long FiredTime { get; set; }
        public long SchedTime { get; set; }
        public int Priority { get; set; }
        public string State { get; set; }
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public bool? IsNonconcurrent { get; set; }
        public bool? RequestsRecovery { get; set; }
    }
}
