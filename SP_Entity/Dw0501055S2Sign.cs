using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dw0501055S2Sign
    {
        public decimal? IdMapingFormList { get; set; }
        public Guid DocUuid { get; set; }
        public string NumRef { get; set; }
        public string Org { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Surname { get; set; }
        public string SignDate { get; set; }
        public decimal? NumSign { get; set; }
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
        public decimal? FinYear { get; set; }
    }
}
