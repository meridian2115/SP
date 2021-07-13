using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsBrTab721BrDList
    {
        public FsBrTab721BrDList()
        {
            FsTab721BrDDetList = new HashSet<FsTab721BrDDetList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R1 { get; set; }
        public string C2R1 { get; set; }
        public string C3R1 { get; set; }
        public decimal? C4R1 { get; set; }
        public decimal? C5R1 { get; set; }
        public decimal? C6R1 { get; set; }
        public decimal? C7R1 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string C0R1 { get; set; }
        public string Pageex { get; set; }
        public string FontStyleRownm { get; set; }
        public bool? DetRows { get; set; }
        public string HrDetRows { get; set; }
        public string SgnDetRows { get; set; }

        public virtual DcArpReport0503721d Doc { get; set; }
        public virtual ICollection<FsTab721BrDDetList> FsTab721BrDDetList { get; set; }
    }
}
