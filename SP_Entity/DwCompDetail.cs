using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwCompDetail
    {
        public string Sorter { get; set; }
        public string NumRef { get; set; }
        public string NumSprFk { get; set; }
        public string Ved { get; set; }
        public string RzName { get; set; }
        public string Rz { get; set; }
        public string Pr { get; set; }
        public string Csr { get; set; }
        public string Vr { get; set; }
        public string Kosgu { get; set; }
        public decimal? Sum1 { get; set; }
        public decimal? Sum2 { get; set; }
        public decimal? Sum3 { get; set; }
        public decimal? FinYear { get; set; }
        public decimal? Idrazdel { get; set; }
        public decimal? IsTotal { get; set; }
        public decimal? IsMigration { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? IdMapingFormList { get; set; }
        public string DetailType { get; set; }
        public Guid? DocUuid { get; set; }
    }
}
