using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT3StatList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Cdkosgu { get; set; }
        public string Cdansection { get; set; }
        public string Okud { get; set; }
        public string Name { get; set; }

        public virtual DcArpStatpredotch Doc { get; set; }
    }
}
