using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFinSubTab402List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsFinSubTab1Listid { get; set; }
        public string Cod { get; set; }
        public string OperR100 { get; set; }
        public string Oper1R100 { get; set; }
        public string C1R4021 { get; set; }
        public string C1aaR4021 { get; set; }
        public string C1aR4021 { get; set; }
        public string C1bR4021 { get; set; }
        public string C1cR4021 { get; set; }
        public string C1dR4021 { get; set; }
        public string C2R4021 { get; set; }
        public string C3R4021 { get; set; }
        public DateTime? C4R4021 { get; set; }
        public string C5R4021 { get; set; }
        public string C6R4021 { get; set; }
        public string C7R4021 { get; set; }
        public string C8R4021 { get; set; }
        public string C9R4021 { get; set; }
        public decimal? C14R4021 { get; set; }
        public decimal? C15R4021 { get; set; }
        public decimal? C17R4021 { get; set; }
        public string C28R4021 { get; set; }

        public virtual FsFinSubTab1List FsFinSubTab1List { get; set; }
    }
}
