using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfodtctnbDiuFuncList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Cbctype { get; set; }
        public string Cbc { get; set; }
        public string Cbctarget { get; set; }
        public decimal? Sumkbk { get; set; }
        public decimal? Suminvalkbk { get; set; }
        public string CbcA { get; set; }
        public string CbcB { get; set; }
        public string CbcC { get; set; }
        public string CbcD { get; set; }

        public virtual DcFamInfodtctnbDoc Doc { get; set; }
    }
}
