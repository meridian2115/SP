using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MgMigrationDetailLog
    {
        public int MigrationDetailLogId { get; set; }
        public int MigrationLogId { get; set; }
        public int? StepId { get; set; }
        public DateTime? LogDate { get; set; }
        public string Pkg { get; set; }
        public string Exec { get; set; }
        public string EventType { get; set; }
        public string Message { get; set; }
        public DateTime? LogTime { get; set; }
        public int? DbSid { get; set; }

        public virtual MgMigrationLog MigrationLog { get; set; }
    }
}
