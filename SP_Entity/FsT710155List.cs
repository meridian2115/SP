using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT710155List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string R1 { get; set; }
        public string R2 { get; set; }
        public string R3 { get; set; }
        public decimal? R4 { get; set; }
        public decimal? R5 { get; set; }
        public decimal? R6 { get; set; }
        public decimal? R7 { get; set; }
        public string Podstroka { get; set; }
        public string Kbk1 { get; set; }
        public string Kbk2 { get; set; }

        public virtual DcArpreport0503155 Doc { get; set; }
    }
}
