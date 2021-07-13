using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR1T10503172List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R11 { get; set; }
        public string C1aR11 { get; set; }
        public string C1bR11 { get; set; }
        public string C1dR11 { get; set; }
        public string C1kR11 { get; set; }
        public decimal? C2R11 { get; set; }
        public decimal? C3R11 { get; set; }
        public string C1eR11 { get; set; }
        public string Numacc2017T1 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }

        public virtual DcReport0503172 Doc { get; set; }
    }
}
