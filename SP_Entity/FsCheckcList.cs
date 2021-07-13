using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsCheckcList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsCheckmultifiltrListid { get; set; }
        public string C1R1 { get; set; }
        public string C2R1 { get; set; }
        public string C3R1 { get; set; }
        public string C4R1 { get; set; }
        public string C5R1 { get; set; }
        public string C0R1 { get; set; }
        public string C4R11 { get; set; }
        public string C5R11 { get; set; }
        public string C6R1 { get; set; }
        public string C7R1 { get; set; }
        public string C8R1 { get; set; }
        public string Nametablechc { get; set; }
        public bool? MultiValueR1 { get; set; }
        public string C9R1 { get; set; }
        public bool? Actualitycheck { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }

        public virtual FsCheckmultifiltrList FsCheckmultifiltrList { get; set; }
    }
}
