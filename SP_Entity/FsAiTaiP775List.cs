using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAiTaiP775List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R011 { get; set; }
        public string C1aR011 { get; set; }
        public string C1bR011 { get; set; }
        public string C1cR011 { get; set; }
        public string C1dR011 { get; set; }
        public decimal? C2R011 { get; set; }
        public DateTime? C3R011 { get; set; }
        public DateTime? C4R011 { get; set; }
        public string C5R011 { get; set; }
        public string C6R011 { get; set; }
        public string C7R011 { get; set; }
        public string C8R011 { get; set; }
        public string TypeString { get; set; }
        public string NumString { get; set; }

        public virtual DcReport0503775 Doc { get; set; }
    }
}
