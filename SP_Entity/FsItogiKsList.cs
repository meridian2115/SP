using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsItogiKsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Ksbu { get; set; }
        public decimal? TotalBy { get; set; }
        public decimal? OverdueBy { get; set; }
        public decimal? TotalEndp { get; set; }
        public decimal? OverdueEndp { get; set; }
        public decimal? ScheduledDebtEndp { get; set; }
        public decimal? Amounto { get; set; }
        public string Kvd { get; set; }
        public string Codeschet { get; set; }
        public string Kosgu { get; set; }
        public string Kbk { get; set; }
        public string NumberBo { get; set; }
        public string InnContractor { get; set; }
        public string Namecontractor { get; set; }
        public string NumberOfEntries { get; set; }
        public string CodeKofk { get; set; }
        public string NameMark { get; set; }

        public virtual DcReport0503192 Doc { get; set; }
    }
}
