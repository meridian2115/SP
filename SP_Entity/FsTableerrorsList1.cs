using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTableerrorsList1
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? Errornumber { get; set; }
        public string Checkname { get; set; }
        public string StCodecr { get; set; }
        public string Section { get; set; }
        public string Checkrow { get; set; }
        public string Content { get; set; }
        public string Value { get; set; }
        public string Commenterr { get; set; }
        public string Checkcolumn { get; set; }
        public string Contentrow { get; set; }
        public string Errortype { get; set; }
        public string Errorlevel { get; set; }

        public virtual DcArpProtocolflk Doc { get; set; }
    }
}
