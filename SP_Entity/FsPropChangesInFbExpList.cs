using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPropChangesInFbExpList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Numbrow { get; set; }
        public string BdcodeSection { get; set; }
        public string BdcodeSubsection { get; set; }
        public string BdcodeTarget { get; set; }
        public string BdcodeExp { get; set; }
        public string GrbsCode { get; set; }
        public decimal? Sumyear { get; set; }
        public decimal? Sumyear1 { get; set; }
        public decimal? Sumyear2 { get; set; }

        public virtual DcSpMemorandum Doc { get; set; }
    }
}
