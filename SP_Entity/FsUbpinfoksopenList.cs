using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpinfoksopenList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Ksvidname { get; set; }
        public string Ksnumber { get; set; }
        public string Ppooktmocode { get; set; }
        public string Tofkorgcode { get; set; }
        public string Tofkname { get; set; }
        public string Servicetofkcode { get; set; }
        public DateTime? Ksopendate { get; set; }
        public DateTime? Ksclosedate { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
