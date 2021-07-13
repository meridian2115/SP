using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAct0503121List
    {
        public FsAct0503121List()
        {
            FsActDet0503121List = new HashSet<FsActDet0503121List>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R3 { get; set; }
        public string C2R3 { get; set; }
        public string C3R3 { get; set; }
        public decimal? C4R3 { get; set; }
        public decimal? C5R3 { get; set; }
        public decimal? C6R3 { get; set; }
        public bool? FlAuto { get; set; }
        public string ArithExpr { get; set; }
        public bool? FlSubrow { get; set; }
        public string Subrownm { get; set; }
        public string C0R3 { get; set; }
        public string Page { get; set; }
        public string FontStyleRownm { get; set; }
        public bool? DetRows { get; set; }
        public string HrDetRows { get; set; }
        public string SgnDetRows { get; set; }

        public virtual DcArpReport0503121D Doc { get; set; }
        public virtual ICollection<FsActDet0503121List> FsActDet0503121List { get; set; }
    }
}
