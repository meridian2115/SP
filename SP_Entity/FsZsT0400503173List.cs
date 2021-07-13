using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsZsT0400503173List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string C0T040 { get; set; }
        public string C1T040 { get; set; }
        public string C2T040 { get; set; }
        public decimal? C3T040 { get; set; }
        public decimal? C4T040 { get; set; }
        public decimal? C5T040 { get; set; }
        public decimal? C6T040 { get; set; }
        public decimal? C7T040 { get; set; }
        public decimal? C8T040 { get; set; }
        public decimal? C9T040 { get; set; }
        public decimal? C10T040 { get; set; }
        public bool? FlAuto { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }

        public virtual DcArpReport05031732019 Doc { get; set; }
    }
}
