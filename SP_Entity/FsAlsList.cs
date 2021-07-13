using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAlsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string RtTypels { get; set; }
        public string RtAccountnum { get; set; }
        public string RtCoderegis { get; set; }
        public string RtFullname { get; set; }
        public string OrgGuid { get; set; }
        public string RtBudgetCode { get; set; }
        public string RtBudgetName { get; set; }

        public virtual DcArpFahAccpac Doc { get; set; }
    }
}
