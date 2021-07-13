using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsApprove723PbsList1
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string ApproverOrder { get; set; }
        public string ApproverDsc { get; set; }
        public DateTime? ApproverStartdate { get; set; }
        public string ApproverUsername { get; set; }
        public string ApproverSfp { get; set; }
        public string ApproverPost { get; set; }
        public string ApproverDepartment { get; set; }
        public string ApproverState { get; set; }
        public string ApproverNote { get; set; }
        public DateTime? ApproverDate { get; set; }
        public bool? Electronicsign { get; set; }

        public virtual DcMscExpendableschdPbs Doc { get; set; }
    }
}
