using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dict
    {
        public decimal Dictid { get; set; }
        public decimal? Version { get; set; }
        public string Globaldocid { get; set; }
        public decimal? Doctypeid { get; set; }
        public string Doctypeversion { get; set; }
        public decimal Docstateid { get; set; }
        public decimal? Checklevel { get; set; }
        public DateTime? Createdate { get; set; }
        public string Createusername { get; set; }
        public decimal? Createorgid { get; set; }
        public string Createorgname { get; set; }
        public string Createorgsystemname { get; set; }
        public string Createcomplexname { get; set; }
        public DateTime? Lastmodifydate { get; set; }
        public string Lastmodifyusername { get; set; }
        public string Lastmodifycomplexname { get; set; }
        public decimal? Localrplversion { get; set; }
        public decimal? Outerrplcomplexid { get; set; }
        public decimal? Outerrplversion { get; set; }
        public decimal? Priority { get; set; }
        public bool? Hasattaches { get; set; }
        public DateTime? Localrpltimestamp { get; set; }
        public decimal Archive { get; set; }
        public bool? HasAttaches1 { get; set; }
        public decimal? AttachesSize { get; set; }
        public decimal? AttachCount { get; set; }
        public decimal Visibilityscope { get; set; }
        public bool Deleted { get; set; }
        public bool Deletedasroot { get; set; }
        public decimal? ChildrenCount { get; set; }
        public decimal? LeafCount { get; set; }
        public decimal Accesslevel { get; set; }
        public string IdempotencyKeys { get; set; }
        public bool? HasNotificationConfig { get; set; }

        public virtual FsDictcommonfields FsDictcommonfields { get; set; }
    }
}
