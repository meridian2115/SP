using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class BuildIndexesAi
    {
        public int BiId { get; set; }
        public int? VersionId { get; set; }
        public Guid RsRepositoryUuid { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public short? Ord { get; set; }
        public string IndexDdl { get; set; }
        public bool? IsActual { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
