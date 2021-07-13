using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpCheckDicts
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PUfosGuid { get; set; }
        public string Npp { get; set; }
        public string Instcd { get; set; }
        public string Nminst { get; set; }
        public string PTofk { get; set; }
        public string PBudgetCode { get; set; }
        public string PNmBudget { get; set; }
        public string PNmUfk { get; set; }
        public DateTime? FinYear { get; set; }
        public string FinYearText { get; set; }
        public string Dict { get; set; }
        public string PTofkCode { get; set; }
        public string Vv { get; set; }
        public string VTofk { get; set; }
        public string Vr { get; set; }
        public bool? ErrCor { get; set; }
        public DateTime? BeginYear { get; set; }
        public DateTime? EndYear { get; set; }
    }
}
