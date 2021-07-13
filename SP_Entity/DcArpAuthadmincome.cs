using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpAuthadmincome
    {
        public DcArpAuthadmincome()
        {
            FsBrRevenuesList = new HashSet<FsBrRevenuesList>();
            FsSfDomesticAaiList = new HashSet<FsSfDomesticAaiList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Surrogat { get; set; }
        public string DocNumber { get; set; }
        public string InstCode { get; set; }
        public string InstName { get; set; }
        public string ChapterCode { get; set; }
        public string BudgetCode { get; set; }
        public string RepPeriod { get; set; }
        public DateTime? RepDate { get; set; }
        public string TypeRepPeriod { get; set; }
        public decimal? BrTotalSum { get; set; }
        public decimal? BrTotalSum1 { get; set; }
        public decimal? BrTotalSum2 { get; set; }
        public decimal? BrTotalSum3 { get; set; }
        public decimal? BrTotalSum4 { get; set; }
        public decimal? BrTotalSum01 { get; set; }
        public decimal? BrTotalSum02 { get; set; }
        public decimal? BrTotalSum03 { get; set; }
        public decimal? BrTotalSum04 { get; set; }
        public decimal? BrTotalSum05 { get; set; }
        public decimal? BrTotalSum06 { get; set; }
        public decimal? BrTotalSum07 { get; set; }
        public decimal? BrTotalSum08 { get; set; }
        public decimal? BrTotalSum09 { get; set; }
        public decimal? BrTotalSum10 { get; set; }
        public decimal? BrTotalSum11 { get; set; }
        public decimal? BrTotalSum12 { get; set; }
        public string CodeForm { get; set; }
        public decimal? SfTotlaSum { get; set; }
        public decimal? SfTotlaSum1 { get; set; }
        public decimal? SfTotlaSum2 { get; set; }
        public decimal? SfTotlaSum3 { get; set; }
        public decimal? SfTotlaSum4 { get; set; }
        public DateTime? Year { get; set; }

        public virtual ICollection<FsBrRevenuesList> FsBrRevenuesList { get; set; }
        public virtual ICollection<FsSfDomesticAaiList> FsSfDomesticAaiList { get; set; }
    }
}
