using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsHrcKbkList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cd { get; set; }
        public string Sp { get; set; }
        public string Cdsp { get; set; }
        public string Upcdsp { get; set; }
        public string Dictname { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
    }
}
