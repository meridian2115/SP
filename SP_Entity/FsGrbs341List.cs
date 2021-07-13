using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsGrbs341List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameGrbs { get; set; }
        public string CodeGrbs { get; set; }
        public decimal? TotalYearbeg { get; set; }
        public decimal? TotalPeriodend { get; set; }

        public virtual DcArpReport0531341 Doc { get; set; }
    }
}
