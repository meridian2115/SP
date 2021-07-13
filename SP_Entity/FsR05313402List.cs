using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR05313402List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string G1 { get; set; }
        public string G2 { get; set; }
        public string G3 { get; set; }
        public string G4 { get; set; }
        public decimal? G5 { get; set; }
        public string Kbk1 { get; set; }
        public string Kbk2 { get; set; }
        public string Kbk3 { get; set; }
        public string Kbk4 { get; set; }
        public string Kbk5 { get; set; }
        public string Gs { get; set; }

        public virtual DcArpreport0531340D Doc { get; set; }
    }
}
