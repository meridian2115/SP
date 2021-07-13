using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcTypesIfdb
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string ArtCodeArticle { get; set; }
        public string BdgtBudgetName { get; set; }
        public string BdgtCd { get; set; }
        public string GrCd { get; set; }
        public string Cdvd { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string AcCd { get; set; }
        public string UpCd { get; set; }
    }
}
