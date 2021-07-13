using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSiTabsiList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Accountnum { get; set; }
        public string Accounttransguid { get; set; }
        public string Signupdate { get; set; }

        public virtual DcExpInfbo Doc { get; set; }
    }
}
