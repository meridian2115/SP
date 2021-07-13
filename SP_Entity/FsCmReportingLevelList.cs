using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCmReportingLevelList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string CdSubordinate { get; set; }
        public string NmSubordinate { get; set; }
        public string NmUser { get; set; }
        public string CdUser { get; set; }

        public virtual DcSubjectsReporting Doc { get; set; }
    }
}
