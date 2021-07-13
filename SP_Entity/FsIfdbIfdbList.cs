using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsIfdbIfdbList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string InstCode { get; set; }
        public string BudgClasCode { get; set; }
        public string AdmCode { get; set; }
        public string CodeSrcBd { get; set; }
        public string IndicatorName { get; set; }
        public decimal? Sum { get; set; }

        public virtual DcArpBudgetlist Doc { get; set; }
    }
}
