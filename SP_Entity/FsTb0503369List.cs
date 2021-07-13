using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTb0503369List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR1 { get; set; }
        public string C1bR1 { get; set; }
        public string C1cR1 { get; set; }
        public string C1dR1 { get; set; }
        public string C1R1All { get; set; }
        public string C1R1Kbk { get; set; }
        public string C1R1Ac { get; set; }
        public decimal? C2R1 { get; set; }
        public decimal? C3R1 { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? SC2R1 { get; set; }
        public decimal? SC3R1 { get; set; }
        public decimal? SC4R1 { get; set; }
        public decimal? SC5R1 { get; set; }
        public string KbkType { get; set; }

        public virtual DcArpReport0503369 Doc { get; set; }
    }
}
