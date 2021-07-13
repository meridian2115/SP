using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsS13S13V125tList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Dim1 { get; set; }
        public string Dim2 { get; set; }
        public string Dim3 { get; set; }
        public string Dim4 { get; set; }
        public decimal? Dat5 { get; set; }
        public decimal? Dat6 { get; set; }
        public decimal? Dat7 { get; set; }
        public string LineNum { get; set; }

        public virtual DcRpPrt0503125tofk Doc { get; set; }
    }
}
