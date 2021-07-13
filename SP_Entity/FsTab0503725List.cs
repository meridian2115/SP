using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTab0503725List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R11 { get; set; }
        public string C2R11 { get; set; }
        public string C3aR11 { get; set; }
        public string C3bR11 { get; set; }
        public string C3cR11 { get; set; }
        public string C3dR11 { get; set; }
        public string C3eR11 { get; set; }
        public decimal? C4R11 { get; set; }
        public decimal? C5R11 { get; set; }
        public string C6aR11 { get; set; }
        public string C6bR11 { get; set; }
        public string PlanAcc { get; set; }
        public string KvfoCode { get; set; }
        public string C6b1R11 { get; set; }
        public string C6b2R11 { get; set; }
        public string Ac { get; set; }
        public string KbkType { get; set; }
        public string Kbk { get; set; }
        public string C3b1R11 { get; set; }
        public string C3b2R11 { get; set; }
        public string C3b3R11 { get; set; }

        public virtual DcArpreport0503725 Doc { get; set; }
    }
}
