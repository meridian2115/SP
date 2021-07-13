using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRepVnk317NpList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string LineNum { get; set; }
        public string ReportNum { get; set; }
        public string Codereportform { get; set; }
        public string NameOfEntity { get; set; }
        public string CodeOfEntity { get; set; }
        public string Subotch { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Accountcode { get; set; }
        public string Code { get; set; }
        public string DostatenameVnk { get; set; }

        public virtual DcPrPrt0503317Np Doc { get; set; }
    }
}
