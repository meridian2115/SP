using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpprevrecnumList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Recordnum { get; set; }
        public string Recordguid { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Recordstatus { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
