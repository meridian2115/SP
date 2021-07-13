using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTblleftList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? Line { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public string Checktablefield { get; set; }
        public string Currdocfield { get; set; }
        public string Currdoctable { get; set; }
        public string Currdoctablefilter { get; set; }
        public string Currdoctablecolumn { get; set; }
        public string Othdoc { get; set; }
        public string Othdocfilter { get; set; }
        public string Othdocfield { get; set; }
        public string Othdoctable { get; set; }
        public string Othdoctablefilter { get; set; }
        public string Othdoctablecolumn { get; set; }
        public string Chck { get; set; }
        public string Form { get; set; }
        public string Section { get; set; }
        public string Clmn { get; set; }
        public string Linenumber { get; set; }
        public string Contentrow { get; set; }
        public string Operator { get; set; }
        public string T1r1 { get; set; }
        public string T1r2 { get; set; }
        public string T1r3 { get; set; }
        public string T1r4 { get; set; }
        public string T1r5 { get; set; }
        public string T1r6 { get; set; }
        public string T1r7 { get; set; }
        public string T1r8 { get; set; }
        public string T1r9 { get; set; }
        public string T1r10 { get; set; }
        public string T1r11 { get; set; }
        public string Field { get; set; }
        public string Fielddoc { get; set; }
        public string Table { get; set; }
        public string Fieldtable { get; set; }
        public string Column { get; set; }
        public string NameR { get; set; }
        public string ExpressionR { get; set; }
        public string FieldR { get; set; }
        public string FielddocR { get; set; }
        public string FieldtableR { get; set; }
        public string LinenumberR { get; set; }
        public string ContentrowR { get; set; }

        public virtual DcPppCrSet Doc { get; set; }
    }
}
