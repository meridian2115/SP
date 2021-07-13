using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRowsconformityList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Param1 { get; set; }
        public string Column1 { get; set; }
        public string Param2 { get; set; }
        public string Column2 { get; set; }
        public string Param1Report { get; set; }
        public string Param2Report { get; set; }
        public string Param1Doctabl { get; set; }
        public string Param2Doctabl { get; set; }
        public string Param1Sysname { get; set; }
        public string Param2Sysname { get; set; }
        public string Leftparamsubstrbeg { get; set; }
        public string Rightparamsubstrbeg { get; set; }
        public string Leftparamsubstrend { get; set; }
        public string Rightparamsubstrend { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
    }
}
