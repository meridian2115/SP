using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoSpeq730List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Tabcounter120 { get; set; }
        public string C2R1201 { get; set; }
        public string C3R1201 { get; set; }
        public decimal? C4R1201 { get; set; }
        public decimal? C5R1201 { get; set; }
        public decimal? C51R1201 { get; set; }
        public decimal? C6R1201 { get; set; }
        public decimal? C7R1201 { get; set; }
        public decimal? C8R1201 { get; set; }
        public decimal? C81R1201 { get; set; }
        public decimal? C9R1201 { get; set; }

        public virtual DcArprep0503730 Doc { get; set; }
    }
}
