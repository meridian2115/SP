using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTblparamList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? Line { get; set; }
        public string Name { get; set; }
        public string Fieldname { get; set; }
        public string Tablename { get; set; }
        public string Filtertable { get; set; }
        public string Tablefieldname { get; set; }
        public string Doctype { get; set; }
        public string Filterquery { get; set; }
        public string Tablenameoderdoc { get; set; }
        public string Filtertableoderdoc { get; set; }
        public string Tablefieldnameoderdoc { get; set; }
        public string T3r1 { get; set; }
        public string T3r2 { get; set; }
        public string T3r3 { get; set; }
        public string T3r4 { get; set; }
        public string Deviation { get; set; }

        public virtual DcPppCrSet Doc { get; set; }
    }
}
