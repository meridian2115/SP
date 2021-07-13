using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBakvsList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Codeadministratorfunding { get; set; }
        public string Codedeficifunding { get; set; }
        public string Headcodedeficifunding { get; set; }
        public decimal? Budgetaryappr { get; set; }
        public decimal? Nodistributed { get; set; }
        public decimal? Recordedonls { get; set; }
        public decimal? Cashdisposalall2 { get; set; }
        public decimal? Copiedfromls { get; set; }
        public decimal? Transferredbankgr2 { get; set; }
        public string KbkCode { get; set; }

        public virtual DcArp0521413OtchetO Doc { get; set; }
    }
}
