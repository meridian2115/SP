using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MwM110
    {
        public decimal? Year { get; set; }
        public string ReportDate { get; set; }
        public string AccNum { get; set; }
        public string GrbsCode { get; set; }
        public string KbkType { get; set; }
        public string Doctype { get; set; }
        public decimal? CrtCode { get; set; }
        public decimal? Accesslevel { get; set; }
    }
}
