using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInst7List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsC3Balance154Listid { get; set; }
        public string Innm { get; set; }
        public string Lncd0200 { get; set; }
        public string Glcd0200 { get; set; }
        public string Accd { get; set; }
        public decimal? Start0200 { get; set; }
        public decimal? End0200 { get; set; }
        public string Grbscd0200 { get; set; }
        public decimal? Docid { get; set; }

        public virtual FsC3Balance154List FsC3Balance154List { get; set; }
    }
}
