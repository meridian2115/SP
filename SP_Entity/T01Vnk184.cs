using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class T01Vnk184
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Dim1 { get; set; }
        public decimal? Dat2 { get; set; }
        public decimal? Dat3 { get; set; }
        public decimal? Dat4 { get; set; }
        public string Dim5 { get; set; }
        public decimal? Dat6 { get; set; }
        public decimal? Dat7 { get; set; }
        public decimal? Dat8 { get; set; }
        public string LineNum { get; set; }

        public virtual DcArp0503184 Doc { get; set; }
    }
}
