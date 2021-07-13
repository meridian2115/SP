using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class BuildIndexesDdlAi
    {
        public Guid RsRepositoryUuid { get; set; }
        public string TableName { get; set; }
        public string IndexDdl { get; set; }
        public string DropDdl { get; set; }
        public short? IdxNum { get; set; }
        public string IndexName { get; set; }
        public bool? BuildExec { get; set; }
        public bool? DropExec { get; set; }
        public DateTime? DdlTimeAdd { get; set; }
    }
}
