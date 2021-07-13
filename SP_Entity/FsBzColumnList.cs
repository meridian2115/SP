using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBzColumnList
    {
        public FsBzColumnList()
        {
            FsBzLimitList = new HashSet<FsBzLimitList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Columnseq { get; set; }
        public string Columndesc { get; set; }
        public string Columnname { get; set; }
        public string DateSetCode { get; set; }
        public string Numpp { get; set; }
        public string SourceType { get; set; }
        public string SourceCode { get; set; }
        public string SourceCodeName { get; set; }
        public string SourceAlias { get; set; }
        public string FieldIsCalc { get; set; }
        public string FieldSource { get; set; }
        public string FieldSourceName { get; set; }
        public string FieldVar { get; set; }
        public string Ppnum { get; set; }
        public bool? Showlimit { get; set; }
        public string SourceCodeCopy { get; set; }

        public virtual DcArpSetBz Doc { get; set; }
        public virtual ICollection<FsBzLimitList> FsBzLimitList { get; set; }
    }
}
