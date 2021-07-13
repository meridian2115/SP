using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsLaAgreer801List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string AgreerUsername { get; set; }
        public string AgreerSfp { get; set; }
        public string AgreerPost { get; set; }
        public string AgreerOrder { get; set; }
        public string AgreerDsc { get; set; }
        public string AgreerNote { get; set; }
        public DateTime? AgreerStartdate { get; set; }
        public DateTime? AgreerDate { get; set; }
        public string AgreerDepartment { get; set; }
        public string AgreerState { get; set; }
        public bool? Electronicsign { get; set; }

        public virtual DcMscApplcashflow Doc { get; set; }
    }
}
