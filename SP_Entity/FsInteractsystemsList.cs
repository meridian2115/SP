using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInteractsystemsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numbrow { get; set; }
        public string Intersystem { get; set; }
        public string Isenabled { get; set; }

        public virtual DcDbdInteractsystems Doc { get; set; }
    }
}
