using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT2KpeList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsT1KpeListid { get; set; }
        public string C1T2 { get; set; }
        public string C2T2 { get; set; }
        public string C3T2 { get; set; }
        public string C4T2 { get; set; }
        public string C5T2 { get; set; }
        public string C6T2 { get; set; }
        public decimal? C7T2 { get; set; }
        public decimal? C8T2 { get; set; }
        public string Kbk { get; set; }

        public virtual FsT1KpeList FsT1KpeList { get; set; }
    }
}
