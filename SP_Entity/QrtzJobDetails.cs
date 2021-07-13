using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class QrtzJobDetails
    {
        public QrtzJobDetails()
        {
            QrtzTriggers = new HashSet<QrtzTriggers>();
        }

        public string SchedName { get; set; }
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public string Description { get; set; }
        public string JobClassName { get; set; }
        public bool IsDurable { get; set; }
        public bool IsNonconcurrent { get; set; }
        public bool IsUpdateData { get; set; }
        public bool RequestsRecovery { get; set; }
        public byte[] JobData { get; set; }

        public virtual ICollection<QrtzTriggers> QrtzTriggers { get; set; }
    }
}
