using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSetFieldKsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Systemnamefield { get; set; }
        public string Namefield { get; set; }
        public string Section { get; set; }
        public string Clmn { get; set; }
        public string Linenumber { get; set; }
        public string Contentrow { get; set; }
        public string Typecontentrow { get; set; }
        public string Docfield { get; set; }
        public string Doctable { get; set; }
        public string Tablenamefield { get; set; }
        public string Tablefilednumbercolum { get; set; }
        public string Formsystemname { get; set; }

        public virtual DcKsSetProtokol Doc { get; set; }
    }
}
