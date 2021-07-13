using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefCsie
    {
        public DcRefCsie()
        {
            FsUseinstnsList = new HashSet<FsUseinstnsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Cd { get; set; }
        public string Nm { get; set; }
        public string TpCd { get; set; }
        public string PppCd { get; set; }
        public string PppNm { get; set; }
        public string SctnsbsctnCd { get; set; }
        public string SctnsbsctnNm { get; set; }
        public string TrgtitmCd { get; set; }
        public string TrgtitmNm { get; set; }
        public string TpexpnsCd { get; set; }
        public string TpexpnsNm { get; set; }
        public string GrpsbgrpincmCd { get; set; }
        public string GrpsbgrpincmNm { get; set; }
        public string ItmsbtmCd { get; set; }
        public string ItmsbtmNm { get; set; }
        public string TpsbtpCd { get; set; }
        public string TpsbtpNm { get; set; }
        public string GrpsbgrpCd { get; set; }
        public string GrpsbgrpNm { get; set; }
        public string TpsbCd { get; set; }
        public string TpsbNm { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string Analyticcode { get; set; }
        public string Analyticname { get; set; }
        public string Ancodekif { get; set; }
        public string Annamekif { get; set; }
        public decimal? Yearstartdate { get; set; }

        public virtual ICollection<FsUseinstnsList> FsUseinstnsList { get; set; }
    }
}
