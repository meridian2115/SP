using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTsNmTransList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C2R4 { get; set; }
        public string C3R4 { get; set; }
        public string C4R4 { get; set; }
        public string C5R4 { get; set; }
        public string C6aR4 { get; set; }
        public string C6R4 { get; set; }
        public decimal? C7R4 { get; set; }
        public decimal? C8R4 { get; set; }
        public string C9R4 { get; set; }
        public string C101R4 { get; set; }
        public string C10R4 { get; set; }
        public string C11R4 { get; set; }
        public string C12R4 { get; set; }
        public string AcctCdR4 { get; set; }
        public string CsmocckieCdR4 { get; set; }
        public string Typeactivityr4 { get; set; }
        public string NumR4 { get; set; }
        public string C6bR4 { get; set; }
        public string C6cR4 { get; set; }
        public string C6Kvd { get; set; }
        public string C6Kosgu { get; set; }
        public string C6Acc { get; set; }

        public virtual DcReport0503125 Doc { get; set; }
    }
}
