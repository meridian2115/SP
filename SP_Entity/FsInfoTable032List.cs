using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoTable032List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C3R032 { get; set; }
        public decimal? C4R032 { get; set; }
        public string C5R032 { get; set; }
        public string C3aR0321 { get; set; }
        public string C3bR0321 { get; set; }
        public string C3cR0321 { get; set; }
        public string C3dR0321 { get; set; }
        public string C3eR0321 { get; set; }

        public virtual DcReport0503177 Doc { get; set; }
    }
}
