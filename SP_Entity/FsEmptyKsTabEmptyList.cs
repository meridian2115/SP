using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsEmptyKsTabEmptyList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Objtype { get; set; }
        public string Docfields { get; set; }
        public string Dintables { get; set; }
        public string Stattable { get; set; }
        public string Stattablefields { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
    }
}
