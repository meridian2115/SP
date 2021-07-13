using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HIncomeTypes
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
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
    }
}
