using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsResamdateList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsSetdateListid { get; set; }
        public string Numpp { get; set; }
        public string BracketLeftCode { get; set; }
        public string Columnsourcetype { get; set; }
        public string SourceCode { get; set; }
        public string SourceCodeSet { get; set; }
        public string SourceCodeName { get; set; }
        public string SourceAlias { get; set; }
        public string FieldIsCalc { get; set; }
        public string FieldSource { get; set; }
        public string FieldSourceName { get; set; }
        public string FieldVar { get; set; }
        public string OperExp { get; set; }
        public string ColumnsourcetypeExp { get; set; }
        public string ColumnsourcetypeExpOp1 { get; set; }
        public string ColumnsourcetypeExpOp2 { get; set; }
        public string ColumnsourcetypeExpOp4 { get; set; }
        public string SourceCodeExp { get; set; }
        public string SourceCodeNameExp { get; set; }
        public string SourceAliasExp { get; set; }
        public string FieldIsCalcExp { get; set; }
        public string FieldSourceExp { get; set; }
        public string FieldSourceNameExp { get; set; }
        public string FieldVarExp { get; set; }
        public string BracketRightCode { get; set; }
        public string LogicUnion { get; set; }

        public virtual FsSetdateList FsSetdateList { get; set; }
    }
}
