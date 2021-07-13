using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpInfoDayTech
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Typeoperation { get; set; }
        public string Nameoperation { get; set; }
        public DateTime? Timeoperation { get; set; }
        public string Login { get; set; }
        public DateTime? Day { get; set; }
    }
}
