using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTsMTransList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R3 { get; set; }
        public string C3R3 { get; set; }
        public string C4R3 { get; set; }
        public string C5R3 { get; set; }
        public string C6aR3 { get; set; }
        public string C6R3 { get; set; }
        public decimal? C7R3 { get; set; }
        public decimal? C8R3 { get; set; }
        public string C9R3 { get; set; }
        public string C101R3 { get; set; }
        public string C10R3 { get; set; }
        public string C11R3 { get; set; }
        public string C12R3 { get; set; }
        public string AcctCdR3 { get; set; }
        public string CsmocckieCdR3 { get; set; }
        public string Typeactivityr3 { get; set; }
        public string NumR3 { get; set; }
        public string C6bR3 { get; set; }
        public string C6cR3 { get; set; }
        public string C6Kvd { get; set; }
        public string C6Kosgu { get; set; }
        public string C6Acc { get; set; }

        public virtual DcReport0503125 Doc { get; set; }
    }
}
