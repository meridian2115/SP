using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QrtzSimpropTriggers
    {
        public string SchedName { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string StrProp1 { get; set; }
        public string StrProp2 { get; set; }
        public string StrProp3 { get; set; }
        public int? IntProp1 { get; set; }
        public int? IntProp2 { get; set; }
        public long? LongProp1 { get; set; }
        public long? LongProp2 { get; set; }
        public decimal? DecProp1 { get; set; }
        public decimal? DecProp2 { get; set; }
        public bool? BoolProp1 { get; set; }
        public bool? BoolProp2 { get; set; }

        public virtual QrtzTriggers QrtzTriggers { get; set; }
    }
}
