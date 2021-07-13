using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Doc
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Globaldocid { get; set; }
        public decimal? Doctypeid { get; set; }
        public string Doctypeversion { get; set; }
        public decimal Docstateid { get; set; }
        public decimal? Approvalstate { get; set; }
        public decimal? Checklevel { get; set; }
        public decimal? Destorgid { get; set; }
        public DateTime? Createdate { get; set; }
        public string Createusername { get; set; }
        public decimal? Createorgid { get; set; }
        public string Createorgname { get; set; }
        public string Createorgsystemname { get; set; }
        public string Createcomplexname { get; set; }
        public DateTime? Lastmodifydate { get; set; }
        public string Lastmodifyusername { get; set; }
        public string Lastmodifycomplexname { get; set; }
        public decimal? Instatenumber { get; set; }
        public decimal? Priority { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? Hasattaches { get; set; }
        public decimal? AttachesSize { get; set; }
        public decimal? AttachCount { get; set; }
        public bool? HasAttaches1 { get; set; }
        public decimal? SignCount { get; set; }
        public decimal DocstateVersion { get; set; }
        public decimal? Createdbyagentid { get; set; }
        public string IdempotencyKeys { get; set; }
        public bool? HasNotificationConfig { get; set; }

        public virtual Org Createdbyagent { get; set; }
        public virtual FsDoccommonfields FsDoccommonfields { get; set; }
    }
}
