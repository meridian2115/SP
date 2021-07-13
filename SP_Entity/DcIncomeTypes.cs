using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcIncomeTypes
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleName { get; set; }
        public string ElementCode { get; set; }
        public string ElementName { get; set; }
        public string KosguCode { get; set; }
        public string KosguName { get; set; }
        public string ParentCode { get; set; }
        public string ParentName { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
    }
}
