using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcBudgets
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cod { get; set; }
        public string Name { get; set; }
        public string BudgetlevelBudlevcd { get; set; }
        public string BudgetlevelBudlevnm { get; set; }
        public string PrbudgetPrcode { get; set; }
        public string PrbudgetPrname { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string BudgOktmo { get; set; }
        public string Guidnsi { get; set; }
    }
}
