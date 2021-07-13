using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCeidedocList
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
        public string NameR { get; set; }
        public string FieldnameR { get; set; }
        public string TablefieldnameR { get; set; }

        public virtual DcCrChkEide Doc { get; set; }
    }
}
