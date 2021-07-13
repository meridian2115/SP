using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsR758GS41DList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public decimal? GS41DC1 { get; set; }
        public string GS41DC2 { get; set; }
        public DateTime? GS41DC3 { get; set; }
        public string GS41DC4 { get; set; }
        public decimal? GS41DC5 { get; set; }
        public decimal? GS41DC6 { get; set; }
        public decimal? GS41DC7 { get; set; }
        public decimal? GS41DC8 { get; set; }
        public decimal? GS41DC9 { get; set; }
        public decimal? GS41DC10 { get; set; }
        public decimal? GS41DC102 { get; set; }
        public string GS41DDocHGuid { get; set; }
        public string GS41DDocGuid { get; set; }
        public decimal? GS41DC72 { get; set; }

        public virtual DcVlsReport0531758 Doc { get; set; }
    }
}
