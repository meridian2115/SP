using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFieldsdocforaccList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Fieldlevel { get; set; }
        public string Fieldsysname { get; set; }
        public string Fieldname { get; set; }
        public string Fieldsystype { get; set; }
        public string Fieldsysnamefah { get; set; }
        public string ApCd { get; set; }
        public string ApNm { get; set; }
        public string Fieldlevelfah { get; set; }

        public virtual DcArpDocforacc Doc { get; set; }
    }
}
