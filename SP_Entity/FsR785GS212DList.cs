using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR785GS212DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string GS212DC1 { get; set; }
        public string GS212DC2 { get; set; }
        public decimal? GS212DC31 { get; set; }
        public decimal? GS212DC32 { get; set; }
        public decimal? GS212DC33 { get; set; }
        public decimal? GS212DC41 { get; set; }
        public decimal? GS212DC42 { get; set; }
        public decimal? GS212DC43 { get; set; }
        public decimal? GS212DC51 { get; set; }
        public decimal? GS212DC52 { get; set; }
        public decimal? GS212DC53 { get; set; }
        public decimal? GS212DC61 { get; set; }
        public decimal? GS212DC62 { get; set; }
        public decimal? GS212DC63 { get; set; }
        public string GS212DC7 { get; set; }
        public string Secrecy { get; set; }

        public virtual DcVlsReport0531785 Doc { get; set; }
    }
}
