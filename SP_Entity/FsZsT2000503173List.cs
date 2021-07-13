using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsZsT2000503173List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string C0T200 { get; set; }
        public string C1T200 { get; set; }
        public string C2T200 { get; set; }
        public decimal? C3T200 { get; set; }
        public decimal? C4T200 { get; set; }
        public decimal? C5T200 { get; set; }
        public decimal? C6T200 { get; set; }
        public decimal? C7T200 { get; set; }
        public decimal? C8T200 { get; set; }
        public decimal? C9T200 { get; set; }
        public decimal? C10T200 { get; set; }
        public bool? FlAuto { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }

        public virtual DcArpReport05031732019 Doc { get; set; }
    }
}
