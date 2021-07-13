using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT1StatList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string CodeGrbsFo { get; set; }
        public string TypeSub { get; set; }
        public string Code { get; set; }
        public string Namereg { get; set; }
        public string PrntCd { get; set; }
        public string PrntNm { get; set; }
        public string CodeTofk { get; set; }
        public string NmTofk { get; set; }
        public string Formcode { get; set; }
        public string ReportBaseCdAi { get; set; }
        public string ReportBaseAcc { get; set; }
        public string Docstateendcorr { get; set; }
        public DateTime? Dateofreport { get; set; }
        public DateTime? Datefororders { get; set; }
        public string Expireddays { get; set; }
        public decimal? Numbcorr { get; set; }
        public string TypeData { get; set; }
        public DateTime? Dateotchet { get; set; }
        public string Seqnum { get; set; }
        public decimal? A1 { get; set; }
        public decimal? A2 { get; set; }
        public string ReportSub { get; set; }

        public virtual DcArpStatpredotch Doc { get; set; }
    }
}
