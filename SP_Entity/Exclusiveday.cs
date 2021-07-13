using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Exclusiveday
    {
        public decimal Exclusivedayid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public DateTime? Calendardate { get; set; }
        public decimal? Daytype { get; set; }
        public string Timetable { get; set; }
    }
}
