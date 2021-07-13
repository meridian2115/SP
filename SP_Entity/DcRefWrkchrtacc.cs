using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefWrkchrtacc
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cd { get; set; }
        public string Cdup { get; set; }
        public string Nm { get; set; }
        public string CsieCd { get; set; }
        public string CsieNm { get; set; }
        public string CsieCdguid { get; set; }
        public string CkfsCd { get; set; }
        public string CkfsNm { get; set; }
        public string SnthtcacctCd { get; set; }
        public string SnthtcacctNm { get; set; }
        public string SnthtcacctCdguid { get; set; }
        public string CsmocckieCd { get; set; }
        public string CsmocckieNm { get; set; }
        public string CsmocckieCdguid { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string PsCd { get; set; }
    }
}
