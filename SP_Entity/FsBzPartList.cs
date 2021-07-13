using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBzPartList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NumColumn { get; set; }
        public string NumColNull { get; set; }
        public string Columnseq { get; set; }
        public string Columndesc { get; set; }
        public string Columnname { get; set; }
        public string ColumnTempDesc { get; set; }
        public string Datatype { get; set; }
        public string GroupBy { get; set; }
        public string GroupByFunc { get; set; }
        public string Sorted { get; set; }
        public string PartPrefix { get; set; }
        public string FieldType { get; set; }
        public string FieldId { get; set; }

        public virtual DcArpSetBz Doc { get; set; }
    }
}
