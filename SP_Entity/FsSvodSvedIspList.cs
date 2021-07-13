using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsSvodSvedIspList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string MainManager { get; set; }
        public string Name { get; set; }
        public string BkCode { get; set; }
        public decimal? C3R030 { get; set; }
        public decimal? C4R030 { get; set; }
        public decimal? C5R030 { get; set; }
        public decimal? C6R030 { get; set; }
        public decimal? C7R030 { get; set; }
        public decimal? C8R030 { get; set; }
        public string LineNum1 { get; set; }

        public virtual DcArpperort0507024 Doc { get; set; }
    }
}
