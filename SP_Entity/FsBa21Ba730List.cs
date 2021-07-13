using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBa21Ba730List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string C1Ba { get; set; }
        public string C2Ba { get; set; }
        public decimal? C4Ba { get; set; }
        public decimal? C5Ba { get; set; }
        public decimal? C6Ba { get; set; }
        public decimal? C7Ba { get; set; }
        public decimal? C8Ba { get; set; }
        public decimal? C9Ba { get; set; }
        public decimal? C10Ba { get; set; }
        public decimal? C11Ba { get; set; }
        public string S { get; set; }

        public virtual DcArpReport05037302019 Doc { get; set; }
    }
}
