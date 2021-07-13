using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QrtzSimpleTriggers
    {
        public string SchedName { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public long RepeatCount { get; set; }
        public long RepeatInterval { get; set; }
        public long TimesTriggered { get; set; }

        public virtual QrtzTriggers QrtzTriggers { get; set; }
    }
}
