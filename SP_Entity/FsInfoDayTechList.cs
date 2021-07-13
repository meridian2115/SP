using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoDayTechList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Typeoperation { get; set; }
        public string Nameoperation { get; set; }
        public DateTime? Timeoperation { get; set; }
        public string Login { get; set; }

        public virtual DcArpFahOperday Doc { get; set; }
    }
}
