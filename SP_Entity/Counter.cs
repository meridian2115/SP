using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Counter
    {
        public decimal Id { get; set; }
        public decimal Version { get; set; }
        public decimal Doctypeid { get; set; }
        public decimal? Orgid { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
        public decimal? Quarter { get; set; }
        public decimal? Week { get; set; }
        public decimal? Day { get; set; }
        public string Fld1Value { get; set; }
        public string Fld2Value { get; set; }
        public string Fld3Value { get; set; }
        public string Fld4Value { get; set; }
        public string Fld5Value { get; set; }
        public decimal? Counter1 { get; set; }
        public decimal? Counter2 { get; set; }
        public decimal? Counter3 { get; set; }
        public decimal? Counter4 { get; set; }
        public decimal? Counter5 { get; set; }
        public DateTime? LastUsed { get; set; }
        public string Counterfieldname { get; set; }
    }
}
