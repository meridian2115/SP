using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR3T30503172List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R31 { get; set; }
        public string C1aR31 { get; set; }
        public string C1bR31 { get; set; }
        public string C1dR31 { get; set; }
        public string C1kR31 { get; set; }
        public string C2R31 { get; set; }
        public string C3R31 { get; set; }
        public DateTime? C4R31 { get; set; }
        public decimal? C5R31 { get; set; }
        public decimal? C6R31 { get; set; }
        public DateTime? C7R31 { get; set; }
        public string C8aR31 { get; set; }
        public string C8bR31 { get; set; }
        public string C8cR31 { get; set; }
        public string C8dR31 { get; set; }
        public string C1eR31 { get; set; }
        public string Numacc2017T3 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }

        public virtual DcReport0503172 Doc { get; set; }
    }
}
