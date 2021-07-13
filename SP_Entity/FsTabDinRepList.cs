using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTabDinRepList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Roworder { get; set; }
        public string Rowcd { get; set; }
        public string Rowkosgu { get; set; }
        public string Rownm { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public string Indentsize { get; set; }
        public string Rownmindent { get; set; }
        public string Indent { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
        public string Page { get; set; }
        public string FillX { get; set; }
        public string FontStyleRownm { get; set; }
        public string FontStyleRowcd { get; set; }
        public string FontStyleRowkosgu { get; set; }
        public string FontStyleCol1 { get; set; }
        public string FontStyleCol2 { get; set; }
        public string FontStyleCol3 { get; set; }
        public string FontStyleCol4 { get; set; }
        public string FontStyleCol5 { get; set; }
        public bool? DetRows { get; set; }
        public string HrDetRows { get; set; }
        public string SgnDetRows { get; set; }

        public virtual DcArpDinamicReports Doc { get; set; }
    }
}
