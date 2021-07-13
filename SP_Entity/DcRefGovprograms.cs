using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefGovprograms
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Programcode { get; set; }
        public string Programname { get; set; }
        public string Programtype { get; set; }
        public string PrPrprogcode { get; set; }
        public string PrPrprogname { get; set; }
        public string PrPrprogtype { get; set; }
        public string BdgtBudgetcode { get; set; }
        public string BdgtBudgetname { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
