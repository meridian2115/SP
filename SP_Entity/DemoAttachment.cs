using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DemoAttachment
    {
        public DemoAttachment()
        {
            DemoAttachment2doc = new HashSet<DemoAttachment2doc>();
        }

        public decimal Attachid { get; set; }
        public decimal? Version { get; set; }
        public string Mimetype { get; set; }
        public string Filename { get; set; }
        public DateTime? Filedate { get; set; }
        public string Filepath { get; set; }
        public byte[] Filecontent { get; set; }
        public string CommentInfo { get; set; }
        public string BusinessType { get; set; }
        public string Guid { get; set; }
        public decimal OrdinalNumber { get; set; }
        public DateTime? Contentdate { get; set; }
        public string Title { get; set; }
        public string Createorgtitle { get; set; }
        public string Createusertitle { get; set; }
        public string Viewable { get; set; }
        public string Status { get; set; }
        public string Temporary { get; set; }
        public decimal Filesize { get; set; }
        public decimal? DocidOld { get; set; }
        public string Wccid { get; set; }
        public string Annotation { get; set; }
        public string Service { get; set; }
        public string ContentHash { get; set; }
        public bool? NeedHistory { get; set; }
        public decimal? ChangeVersion { get; set; }
        public string Blocked { get; set; }
        public byte[] Signatures { get; set; }

        public virtual ICollection<DemoAttachment2doc> DemoAttachment2doc { get; set; }
    }
}
