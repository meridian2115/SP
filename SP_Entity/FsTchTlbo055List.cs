using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTchTlbo055List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Numbrow { get; set; }
        public string Kbk { get; set; }
        public string Objcode { get; set; }
        public string Personalaccountgrbs { get; set; }
        public decimal? SyYear { get; set; }
        public decimal? SyYear1 { get; set; }
        public decimal? SyYear2 { get; set; }
        public decimal? SyapprYear { get; set; }
        public decimal? SyapprYear1 { get; set; }
        public decimal? SyapprYear2 { get; set; }
        public decimal? SylockYear { get; set; }
        public decimal? SylockYear1 { get; set; }
        public decimal? SylockYear2 { get; set; }
        public decimal? SydtYear { get; set; }
        public decimal? SydtYear1 { get; set; }
        public decimal? SydtYear2 { get; set; }
        public decimal? SyktYear { get; set; }
        public decimal? SyktYear1 { get; set; }
        public decimal? SyktYear2 { get; set; }
        public decimal? SycontrolYear { get; set; }
        public decimal? SycontrolYear1 { get; set; }
        public decimal? SycontrolYear2 { get; set; }

        public virtual DcDbdSumbudlistGrbsGaif Doc { get; set; }
    }
}
