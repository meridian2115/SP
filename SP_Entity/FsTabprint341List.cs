using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabprint341List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumString { get; set; }
        public string TypeString { get; set; }
        public string NameP { get; set; }
        public string CodeGrbsP { get; set; }
        public string CodePbsP { get; set; }
        public decimal? SumYearbegp { get; set; }
        public decimal? SumPeriodendp { get; set; }
        public string NameString { get; set; }

        public virtual DcArpReport0531341 Doc { get; set; }
    }
}
