using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahErrorYear
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TofkCode { get; set; }
        public string AccountingBook { get; set; }
        public string TypeError { get; set; }
        public bool? ShowDocs { get; set; }
        public string Instcd { get; set; }
        public string PSystem { get; set; }
        public string PAccountingBook { get; set; }
        public string PShowDocs { get; set; }
        public string PTypeError { get; set; }
        public string Npp { get; set; }
        public string PUfosGuid { get; set; }
        public string Stat { get; set; }
        public string Phase { get; set; }
        public string TextCompletion { get; set; }
        public string Year { get; set; }
        public string PTechnicalPa { get; set; }
    }
}
