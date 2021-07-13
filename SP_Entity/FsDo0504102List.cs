using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsDo0504102List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Npp { get; set; }
        public string TypeDoc { get; set; }
        public string Num { get; set; }
        public DateTime? Data { get; set; }
        public string Url { get; set; }

        public virtual DcArpFah05041021 Doc { get; set; }
    }
}
