using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcAccountOption
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string ParamCode { get; set; }
        public string ParamName { get; set; }
        public string ParamType { get; set; }
        public string ParamValueSt { get; set; }
        public DateTime? ParamValueDt { get; set; }
        public decimal? ParamValueNm { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
