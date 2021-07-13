using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsEndyearList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string PTofkCode { get; set; }
        public string BudgetCode { get; set; }
        public DateTime? Dateof { get; set; }
        public string DrPa { get; set; }
        public string CrPa { get; set; }
        public string Dtacc { get; set; }
        public string Ctacc { get; set; }
        public decimal? AccountedSumma { get; set; }

        public virtual DcArpFahEndyear Doc { get; set; }
    }
}
