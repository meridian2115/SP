using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsIndexesList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameOfIndex { get; set; }
        public string TypeReport { get; set; }
        public string AnSecCode { get; set; }
        public string InstitutionCode { get; set; }
        public string CodeRepSubj { get; set; }
        public string FilledName { get; set; }

        public virtual DcRatiosControl Doc { get; set; }
    }
}
