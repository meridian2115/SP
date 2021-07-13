using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCeiderightList
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
        public string Fieldname1 { get; set; }
        public string Tablenameoderdoc { get; set; }
        public string Filtertableoderdoc { get; set; }
        public string Tablefieldnameoderdoc { get; set; }
        public string Form { get; set; }
        public string Section { get; set; }
        public string Column { get; set; }
        public string Linenumber { get; set; }
        public string Contentrow { get; set; }
        public string Operator { get; set; }
        public string NameR { get; set; }
        public string FieldnameR { get; set; }
        public string TablefieldnameR { get; set; }
        public string FieldnameR1 { get; set; }
        public string TablefieldnameoderdocR { get; set; }
        public string LinenumberR { get; set; }
        public string ContentrowR { get; set; }

        public virtual DcCrChkEide Doc { get; set; }
    }
}
