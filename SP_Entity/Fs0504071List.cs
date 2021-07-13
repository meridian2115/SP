using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Fs0504071List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? C0 { get; set; }
        public DateTime? C1 { get; set; }
        public string C1String { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public string C8 { get; set; }
        public string C9 { get; set; }
        public decimal? C10 { get; set; }
        public string HDocGuid { get; set; }
        public string HDocType { get; set; }
        public string Dtype { get; set; }

        public virtual DcArpFah0504071 Doc { get; set; }
    }
}
