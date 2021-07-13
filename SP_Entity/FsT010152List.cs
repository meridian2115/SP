using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT010152List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string StrKod { get; set; }
        public string KbkDoh { get; set; }
        public string TypeKbk { get; set; }
        public decimal? DSub { get; set; }
        public decimal? DMp { get; set; }
        public decimal? DCo { get; set; }
        public decimal? DCog { get; set; }
        public decimal? DVrg { get; set; }
        public decimal? DMo { get; set; }
        public decimal? DGor { get; set; }
        public decimal? DCc { get; set; }
        public decimal? DTvgf { get; set; }
        public decimal? DAll { get; set; }
        public string Kbk1 { get; set; }
        public string Kbk2 { get; set; }
        public string Kbk3 { get; set; }
        public string Kbk4 { get; set; }

        public virtual DcArpreport0503152 Doc { get; set; }
    }
}
