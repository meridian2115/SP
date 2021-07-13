using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFaip604List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string FaipT01 { get; set; }
        public string FaipT02 { get; set; }
        public string FaipT03 { get; set; }
        public string FaipT04 { get; set; }
        public string FaipT05 { get; set; }
        public string FaipT06 { get; set; }
        public decimal? FaipT07 { get; set; }
        public decimal? FaipT08 { get; set; }
        public decimal? FaipT09 { get; set; }
        public decimal? FaipT10 { get; set; }
        public decimal? FaipT11 { get; set; }
        public string FaipKbk { get; set; }

        public virtual DcArpReport0506604 Doc { get; set; }
    }
}
