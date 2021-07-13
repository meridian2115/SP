using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MgMigrationVersionDoc
    {
        public int MigrationVersionDocId { get; set; }
        public int MigrationDocId { get; set; }
        public string DocName { get; set; }
        public string FormCode { get; set; }
        public Guid? RsCatalogUuid { get; set; }
        public bool? EnabledFlag { get; set; }
        public short? OrderNum { get; set; }
        public int? IdForm { get; set; }
        public int? IdVer { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual MgMigrationDoc MigrationDoc { get; set; }
        public virtual RsCatalogAi RsCatalogUu { get; set; }
    }
}
