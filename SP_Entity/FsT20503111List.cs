using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT20503111List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1aR02100 { get; set; }
        public string C1bR02100 { get; set; }
        public string C1cR02100 { get; set; }
        public string C1dR02100 { get; set; }
        public string C1eR02100 { get; set; }
        public string C1gR02100 { get; set; }
        public decimal? C2R02100 { get; set; }
        public decimal? C3R02100 { get; set; }
        public decimal? C4R02100 { get; set; }
        public decimal? C5R02100 { get; set; }
        public decimal? C6R02100 { get; set; }
        public decimal? C7R02100 { get; set; }
        public string C1b1R02100 { get; set; }
        public string C1b1R02Rash { get; set; }
        public string C1b1R02Doh { get; set; }
        public string C1baR02100 { get; set; }
        public string C1bbR02100 { get; set; }
        public string C1bcR02100 { get; set; }

        public virtual DcArpReport0503111 Doc { get; set; }
    }
}
