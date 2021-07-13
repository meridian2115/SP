using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsParamtablefiltersList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Param { get; set; }
        public string Column1 { get; set; }
        public string Relation { get; set; }
        public string Column2 { get; set; }
        public string ParamReport { get; set; }
        public string ParamDoctabl { get; set; }
        public string NumString { get; set; }
        public decimal? S1 { get; set; }
        public bool? Ae { get; set; }
        public string RelationAe { get; set; }
        public string ParamSysname { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
    }
}
