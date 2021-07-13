using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCheckList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsCheckmultifiltrListid { get; set; }
        public string C1R2 { get; set; }
        public string C2R2 { get; set; }
        public string C3R2 { get; set; }
        public string C4R2 { get; set; }
        public string C5R2 { get; set; }
        public string C0R2 { get; set; }
        public string C4R21 { get; set; }
        public string C5R21 { get; set; }
        public string C6R2 { get; set; }
        public string C7R2 { get; set; }
        public string C8R2 { get; set; }
        public string Nametablec { get; set; }
        public bool? MultiValueR2 { get; set; }
        public string C9R2 { get; set; }
        public string Colmn { get; set; }
        public bool? Actualitycheck { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }

        public virtual FsCheckmultifiltrList FsCheckmultifiltrList { get; set; }
    }
}
