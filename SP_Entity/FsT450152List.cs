using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT450152List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string StrKod { get; set; }
        public string KbkRash { get; set; }
        public string TypeKbk { get; set; }
        public decimal? RSub { get; set; }
        public decimal? RMp { get; set; }
        public decimal? RCo { get; set; }
        public decimal? RCog { get; set; }
        public decimal? RVrg { get; set; }
        public decimal? RMo { get; set; }
        public decimal? RGor { get; set; }
        public decimal? RCc { get; set; }
        public decimal? RTvgf { get; set; }
        public decimal? RAll { get; set; }
        public string Kbk1 { get; set; }
        public string Kbk2 { get; set; }

        public virtual DcArpreport0503152 Doc { get; set; }
    }
}
