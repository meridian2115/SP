using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwSprBroSign
    {
        public string DocUuid { get; set; }
        public decimal? IsTotal { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? IsMigration { get; set; }
        public string Org { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Surname { get; set; }
        public string SignDate { get; set; }
        public decimal? NumSign { get; set; }
        public DateTime? DateOt { get; set; }
    }
}
