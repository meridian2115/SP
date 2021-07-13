using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsReasonschangesList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Changebegindate { get; set; }
        public string Changedocnumber { get; set; }
        public DateTime? Changedocdate { get; set; }

        public virtual DcRefTofk Doc { get; set; }
    }
}
