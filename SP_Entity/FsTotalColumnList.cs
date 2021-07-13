using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTotalColumnList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsTotalDataListid { get; set; }
        public string Columndesc { get; set; }
        public string Columnname { get; set; }
        public string ColumnType { get; set; }
        public string ParentsColumnname { get; set; }
        public string ParentsColumndesc { get; set; }
        public string ParentsDatatype { get; set; }
        public string DataSign { get; set; }
        public string ParamSysname { get; set; }

        public virtual FsTotalDataList FsTotalDataList { get; set; }
    }
}
