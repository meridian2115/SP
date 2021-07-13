using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsZrosnPbsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string DbBasepaysign { get; set; }
        public string DbKind { get; set; }
        public string DbDocnumber { get; set; }
        public DateTime? DbDocdate { get; set; }
        public string DbSubject { get; set; }
        public string TechKind { get; set; }

        public virtual DcMscApplcashflowPbs Doc { get; set; }
    }
}
