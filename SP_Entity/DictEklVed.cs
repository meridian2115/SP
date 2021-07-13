using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DictEklVed
    {
        public decimal IdEkl { get; set; }
        public decimal IdKlr { get; set; }
        public string Code { get; set; }
        public string CodeParent { get; set; }
        public string Name { get; set; }
        public int? FinYear { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
