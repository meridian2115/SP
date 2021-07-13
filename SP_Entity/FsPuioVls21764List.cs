using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPuioVls21764List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Activity { get; set; }
        public string FundSource { get; set; }
        public string Bcc { get; set; }
        public string Tofk { get; set; }
        public string Pa { get; set; }
        public string Codecs { get; set; }
        public string Obligation { get; set; }
        public string Okato { get; set; }
        public string Faip { get; set; }
        public string DocHType { get; set; }
        public string DocHRegNum { get; set; }
        public DateTime? DocHRegDate { get; set; }
        public string DocHGuid { get; set; }
        public string DocLType { get; set; }
        public string DocLRegNum { get; set; }
        public DateTime? DocLRegDate { get; set; }
        public string DocLGuid { get; set; }
        public DateTime? GlDate { get; set; }
        public decimal? AccountedSumDr { get; set; }
        public decimal? AccountedSumCr { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string SubOrganization { get; set; }

        public virtual DcVlsReport0531764 Doc { get; set; }
    }
}
