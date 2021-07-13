using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR2T20503172List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R21 { get; set; }
        public string C1aR21 { get; set; }
        public string C1bR21 { get; set; }
        public string C1dR21 { get; set; }
        public string C1kR21 { get; set; }
        public decimal? C2R21 { get; set; }
        public decimal? C3R21 { get; set; }
        public string C1eR21 { get; set; }
        public string Numacc2017T2 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }

        public virtual DcReport0503172 Doc { get; set; }
    }
}
