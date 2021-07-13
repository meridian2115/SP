using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsLboList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string CustomerCode { get; set; }
        public string KbkCode1 { get; set; }
        public string KbkCode2 { get; set; }
        public string KbkCode3 { get; set; }
        public string KbkCode4 { get; set; }
        public decimal? Notdistributedma { get; set; }
        public decimal? Nodistributedmanager { get; set; }
        public decimal? Distributedmanager { get; set; }
        public decimal? Cashdisposalall { get; set; }
        public decimal? Writtenoffls { get; set; }
        public decimal? Transferredbank { get; set; }

        public virtual DcArp0521413OtchetO Doc { get; set; }
    }
}
