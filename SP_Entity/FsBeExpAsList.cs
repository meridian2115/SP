using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBeExpAsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string ManBudgFundsCode { get; set; }
        public string BudgClasCode { get; set; }
        public string ChptrBdgClssCode { get; set; }
        public string SectionSubsection { get; set; }
        public string TargetArticle { get; set; }
        public string ExpensesType { get; set; }
        public string OpcodeGovSector { get; set; }
        public string IndicatorName { get; set; }
        public decimal? Sum { get; set; }

        public virtual DcArpBudgetlist Doc { get; set; }
    }
}
