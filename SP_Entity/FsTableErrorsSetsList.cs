using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTableErrorsSetsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? Errornumber { get; set; }
        public string Codecr { get; set; }
        public string StCodecr { get; set; }
        public string Errorlevel { get; set; }
        public string Reportformleft { get; set; }
        public string Sectionleft { get; set; }
        public string Columnleft { get; set; }
        public string Rowleft { get; set; }
        public string Contentrowleft { get; set; }
        public string Operatorleft { get; set; }
        public decimal? Valueleft { get; set; }
        public string Ratio { get; set; }
        public string Reportformright { get; set; }
        public string Sectionright { get; set; }
        public string Columnright { get; set; }
        public string Rowright { get; set; }
        public string Contentrowright { get; set; }
        public string Operatorright { get; set; }
        public decimal? Valueright { get; set; }
        public decimal? Error { get; set; }
        public string CommentErr { get; set; }
        public string Errortype { get; set; }

        public virtual DcArpPrtcolbdkSets Doc { get; set; }
    }
}
