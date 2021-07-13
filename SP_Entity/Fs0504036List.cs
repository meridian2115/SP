using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Fs0504036List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Npp { get; set; }
        public string Nk { get; set; }
        public string Nac { get; set; }
        public decimal? DStart { get; set; }
        public decimal? CStart { get; set; }
        public decimal? DTurnover { get; set; }
        public decimal? CTurnover { get; set; }
        public decimal? DEnd { get; set; }
        public decimal? CEnd { get; set; }

        public virtual DcArpFah0504036 Doc { get; set; }
    }
}
