using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsErrorsTabTmpList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public string Doctype { get; set; }
        public string Crcode { get; set; }
        public string Crtype { get; set; }
        public string Errortext { get; set; }
        public string Det { get; set; }
        public string Reslt { get; set; }
        public string Errorname { get; set; }
        public string Filename { get; set; }
        public string GroupTypeksCd { get; set; }
        public string GroupTypeksNm { get; set; }
        public string GroupRazdelCd { get; set; }
        public string GroupRazdelNm { get; set; }

        public virtual DcSpImportlog Doc { get; set; }
    }
}
