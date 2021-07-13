using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcPppCodes1105
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string BudgetsBudgetCode { get; set; }
        public string BudgetsBudgetName { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public bool? Gadb { get; set; }
        public bool? Grbs { get; set; }
        public bool? Gaif { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Guidnsi { get; set; }
    }
}
