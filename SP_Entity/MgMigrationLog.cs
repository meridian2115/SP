using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MgMigrationLog
    {
        public MgMigrationLog()
        {
            MgMigrationDetailLog = new HashSet<MgMigrationDetailLog>();
        }

        public int MigrationLogId { get; set; }
        public string MigrationName { get; set; }
        public string MigStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<MgMigrationDetailLog> MgMigrationDetailLog { get; set; }
    }
}
