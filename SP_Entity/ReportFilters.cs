using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class ReportFilters
    {
        public int Id { get; set; }
        public Guid? ReportUuid { get; set; }
        public string ReportName { get; set; }
        public string DictCode { get; set; }
        public string NewDictCode { get; set; }
        public string NewSqlStr { get; set; }
        public bool IsHierarchy { get; set; }
        public string NewHierSqlStr { get; set; }
        public string UsedMw { get; set; }
        public string NumOpz { get; set; }
        public string UsedColumn { get; set; }
        public string UsedUfosDictionary { get; set; }
        public bool? IsReady { get; set; }
        public bool? IsMigr { get; set; }
        public short? Level { get; set; }

        public virtual DictDescrAi DictCodeNavigation { get; set; }
        public virtual RsRepositoryAi ReportUu { get; set; }
        public virtual MatViews UsedMwNavigation { get; set; }
    }
}
