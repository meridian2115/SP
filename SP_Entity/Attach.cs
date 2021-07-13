using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Attach
    {
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
        public char Viewable { get; set; }
        public string Status { get; set; }
        public char Temporary { get; set; }
        public decimal Filesize { get; set; }
        public decimal? DocidOld { get; set; }
        public string Wccid { get; set; }
        public string Annotation { get; set; }
        public char Service { get; set; }
        public string ContentHash { get; set; }
        public bool? NeedHistory { get; set; }
        public string Blocked { get; set; }
        public decimal? ChangeVersion { get; set; }
    }
}
