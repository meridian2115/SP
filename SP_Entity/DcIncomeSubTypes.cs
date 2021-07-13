using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcIncomeSubTypes
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string IncomeTypesCodeVd { get; set; }
        public string IncomeTypesNameVd { get; set; }
        public string KosguKosguCode { get; set; }
        public string KosguKosguName { get; set; }
        public string BudgetsBudgetName { get; set; }
        public string BudgetsBdgtcd { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
