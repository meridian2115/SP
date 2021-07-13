using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcTpclAccTrnsctns
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Corr { get; set; }
        public DateTime? CorrOid { get; set; }
        public string AccountDt { get; set; }
        public DateTime? AccountDtOid { get; set; }
        public string AccountKt { get; set; }
        public DateTime? AccountKtOid { get; set; }
        public string TypeCorr { get; set; }
    }
}
