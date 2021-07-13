using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoTabr1814List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C11 { get; set; }
        public string CKbk { get; set; }
        public string C21 { get; set; }
        public string C31 { get; set; }
        public string C41 { get; set; }
        public string C51 { get; set; }
        public decimal? C61 { get; set; }
        public decimal? C71 { get; set; }
        public decimal? C81 { get; set; }
        public decimal? C91 { get; set; }
        public string NumString { get; set; }

        public virtual DcArpReport0503814 Doc { get; set; }
    }
}
