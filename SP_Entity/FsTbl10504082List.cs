using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTbl10504082List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C21 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C41 { get; set; }
        public decimal? C5 { get; set; }
        public decimal? C6 { get; set; }
        public decimal? C7 { get; set; }

        public virtual DcArpFah0504082 Doc { get; set; }
    }
}
