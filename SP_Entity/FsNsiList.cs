using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsNsiList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Nm { get; set; }
        public string NmSys { get; set; }
        public string NmNsi { get; set; }
        public string NmSysNsi { get; set; }
        public string Guid { get; set; }
        public string GuidNsi { get; set; }
        public DateTime? Dt { get; set; }
        public string Mapping { get; set; }
        public string Filter { get; set; }

        public virtual DcArpUpdateNsi Doc { get; set; }
    }
}
