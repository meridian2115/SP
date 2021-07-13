using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBzDescList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Columnseq { get; set; }
        public string FieldDesc { get; set; }
        public string FieldSysname { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldId { get; set; }
        public string FieldTypetable { get; set; }

        public virtual DcArpSetBz Doc { get; set; }
    }
}
