using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT520152List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string StrKod { get; set; }
        public string KbkIst { get; set; }
        public string TypeKbk { get; set; }
        public decimal? IstSub { get; set; }
        public decimal? IstMp { get; set; }
        public decimal? IstCo { get; set; }
        public decimal? IstCog { get; set; }
        public decimal? IstVrg { get; set; }
        public decimal? IstMo { get; set; }
        public decimal? IstGor { get; set; }
        public decimal? IstCc { get; set; }
        public decimal? IstTvgf { get; set; }
        public decimal? IstAll { get; set; }
        public string Kbk1 { get; set; }
        public string Kbk2 { get; set; }
        public string Kbk3 { get; set; }
        public string Kbk4 { get; set; }
        public string Kbk5 { get; set; }

        public virtual DcArpreport0503152 Doc { get; set; }
    }
}
