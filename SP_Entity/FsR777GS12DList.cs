using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR777GS12DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS1DC1 { get; set; }
        public decimal? GS1DC21 { get; set; }
        public decimal? GS1DC22 { get; set; }
        public decimal? GS1DC23 { get; set; }
        public decimal? GS1DC31 { get; set; }
        public decimal? GS1DC32 { get; set; }
        public decimal? GS1DC33 { get; set; }
        public decimal? GS1DC41 { get; set; }
        public decimal? GS1DC42 { get; set; }
        public decimal? GS1DC43 { get; set; }
        public decimal? GS1DC51 { get; set; }
        public decimal? GS1DC52 { get; set; }
        public decimal? GS1DC53 { get; set; }
        public decimal? GS1DC61 { get; set; }
        public decimal? GS1DC62 { get; set; }
        public decimal? GS1DC63 { get; set; }
        public string GS1DC7 { get; set; }

        public virtual DcVlsReport0531777 Doc { get; set; }
    }
}
