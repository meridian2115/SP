using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD3ZapList
    {
        public FsD3ZapList()
        {
            FsD3ZSlList = new HashSet<FsD3ZSlList>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NZap { get; set; }
        public bool? PrNov { get; set; }
        public string PacientIdPac { get; set; }
        public string PacientVpolis { get; set; }
        public string PacientSpolis { get; set; }
        public string PacientNpolis { get; set; }
        public string PacientStOkato { get; set; }
        public string PacientSmo { get; set; }
        public string PacientSmoOgrn { get; set; }
        public string PacientSmoOk { get; set; }
        public string PacientSmoNam { get; set; }
        public bool? PacientNovor { get; set; }

        public virtual DcD3Ffoms Doc { get; set; }
        public virtual ICollection<FsD3ZSlList> FsD3ZSlList { get; set; }
    }
}
