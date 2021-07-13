using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR1Revenue416List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string R1C11 { get; set; }
        public string R1C21 { get; set; }
        public string R1C31 { get; set; }
        public string R1C41 { get; set; }
        public string R1C51 { get; set; }
        public decimal? R1C61 { get; set; }
        public string R1Kbk { get; set; }
        public string NumR1 { get; set; }

        public virtual DcArpReport0521416 Doc { get; set; }
    }
}
