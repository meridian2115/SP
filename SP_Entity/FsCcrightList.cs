using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCcrightList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? Line { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public string Field { get; set; }
        public string Doctype { get; set; }
        public string Filter { get; set; }
        public string Fielddoc { get; set; }
        public string Form { get; set; }
        public string Section { get; set; }
        public string Column { get; set; }
        public string Linenumber { get; set; }
        public string Contentrow { get; set; }
        public string Operator { get; set; }
        public string NameR { get; set; }
        public string ExpressionR { get; set; }
        public string FieldR { get; set; }
        public string FielddocR { get; set; }
        public string LinenumberR { get; set; }
        public string ContentrowR { get; set; }

        public virtual DcCrChkCmpr Doc { get; set; }
    }
}
