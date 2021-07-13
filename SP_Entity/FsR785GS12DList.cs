using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR785GS12DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS12DC1 { get; set; }
        public decimal? GS12DC21 { get; set; }
        public decimal? GS12DC22 { get; set; }
        public decimal? GS12DC23 { get; set; }
        public decimal? GS12DC31 { get; set; }
        public decimal? GS12DC32 { get; set; }
        public decimal? GS12DC33 { get; set; }
        public decimal? GS12DC41 { get; set; }
        public decimal? GS12DC42 { get; set; }
        public decimal? GS12DC43 { get; set; }
        public decimal? GS12DC51 { get; set; }
        public decimal? GS12DC52 { get; set; }
        public decimal? GS12DC53 { get; set; }
        public string GS12DC6 { get; set; }
        public string Secrecy { get; set; }

        public virtual DcVlsReport0531785 Doc { get; set; }
    }
}
