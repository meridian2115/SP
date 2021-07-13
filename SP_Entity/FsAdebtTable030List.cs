﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAdebtTable030List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R030 { get; set; }
        public string C2R030 { get; set; }
        public string C3R030 { get; set; }
        public string C3aR030 { get; set; }
        public string C3bR030 { get; set; }
        public string C3cR030 { get; set; }
        public decimal? C4R030 { get; set; }
        public decimal? C5R030 { get; set; }
        public decimal? C6R030 { get; set; }
        public decimal? C7R030 { get; set; }
        public decimal? C8R030 { get; set; }
        public decimal? C9R030 { get; set; }
        public decimal? C10R030 { get; set; }
        public decimal? C11R030 { get; set; }
        public decimal? C12R030 { get; set; }
        public decimal? C13R030 { get; set; }

        public virtual DcArpReport0503191 Doc { get; set; }
    }
}
