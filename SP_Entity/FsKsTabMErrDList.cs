using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsKsTabMErrDList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Okud { get; set; }
        public string Ai { get; set; }
        public string Acc { get; set; }
        public string RepNum { get; set; }
        public string RepName { get; set; }
        public string RepType { get; set; }
        public string RepState { get; set; }
        public string Codecr { get; set; }
        public string CommentErr { get; set; }
        public string Errortype { get; set; }

        public virtual DcArpMonitoring Doc { get; set; }
    }
}
