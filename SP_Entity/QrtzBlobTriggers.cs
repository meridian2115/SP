using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QrtzBlobTriggers
    {
        public string SchedName { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public byte[] BlobData { get; set; }

        public virtual QrtzTriggers QrtzTriggers { get; set; }
    }
}
