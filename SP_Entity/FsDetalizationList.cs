using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsDetalizationList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Param { get; set; }
        public string DictSysname { get; set; }
        public string DictFieldname { get; set; }
        public string DictCodefieldname { get; set; }
        public string DictUpfieldname { get; set; }
        public string NumString { get; set; }
        public decimal? S1 { get; set; }
        public string Relation { get; set; }
        public string Systemnamereportform { get; set; }
        public string DictUpfieldnamebuf { get; set; }
        public bool? Npa { get; set; }

        public virtual DcCrSetT2 Doc { get; set; }
    }
}
