using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsValsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cd { get; set; }
        public string Nm { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }

        public virtual DcRefLists Doc { get; set; }
    }
}
