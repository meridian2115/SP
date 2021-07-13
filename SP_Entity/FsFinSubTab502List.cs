using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFinSubTab502List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsFinSubTab1Listid { get; set; }
        public string Cod { get; set; }
        public string OperR100 { get; set; }
        public string Oper1R100 { get; set; }
        public string C1R5021 { get; set; }
        public string C1aaR5021 { get; set; }
        public string C1aR5021 { get; set; }
        public string C1bR5021 { get; set; }
        public string C1cR5021 { get; set; }
        public string C1dR5021 { get; set; }
        public string C2R5021 { get; set; }
        public string C3R5021 { get; set; }
        public DateTime? C4R5021 { get; set; }
        public string C5R5021 { get; set; }
        public string C6R5021 { get; set; }
        public string C7R5021 { get; set; }
        public string C8R5021 { get; set; }
        public string C9R5021 { get; set; }
        public decimal? C14R5021 { get; set; }
        public decimal? C15R5021 { get; set; }
        public decimal? C17R5021 { get; set; }
        public string C28R5021 { get; set; }

        public virtual FsFinSubTab1List FsFinSubTab1List { get; set; }
    }
}
