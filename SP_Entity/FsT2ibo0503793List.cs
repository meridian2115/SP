using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT2ibo0503793List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumberBo { get; set; }
        public string CodeKofk { get; set; }
        public string InnContractor { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TotalBy { get; set; }
        public decimal? OverdueBy { get; set; }
        public decimal? TotalEndp { get; set; }
        public decimal? Confnf { get; set; }
        public decimal? Arrears { get; set; }
        public decimal? Repayfb { get; set; }
        public decimal? ScheduledDebtEndp { get; set; }
        public string Namecontr { get; set; }

        public virtual DcArpReport0503793 Doc { get; set; }
    }
}
