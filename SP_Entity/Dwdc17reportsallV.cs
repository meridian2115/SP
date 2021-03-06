using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dwdc17reportsallV
    {
        public Guid? Uuid { get; set; }
        public int? Year { get; set; }
        public int? PlanYear { get; set; }
        public string DocNum { get; set; }
        public DateTime? DateOt { get; set; }
        public string Grbs { get; set; }
        public string Rzpr { get; set; }
        public string Rz { get; set; }
        public string Pr { get; set; }
        public string Csr { get; set; }
        public string Vr { get; set; }
        public string Vid { get; set; }
        public decimal? Vost { get; set; }
        public decimal? Iost { get; set; }
        public decimal? SumVid { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
        public string SvrCode { get; set; }
    }
}
