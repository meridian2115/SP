using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HTpclAccTrnsctns
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Corr { get; set; }
        public decimal? CorrOid { get; set; }
        public string AccountDt { get; set; }
        public decimal? AccountDtOid { get; set; }
        public string AccountKt { get; set; }
        public decimal? AccountKtOid { get; set; }
        public string TypeCorr { get; set; }
    }
}
