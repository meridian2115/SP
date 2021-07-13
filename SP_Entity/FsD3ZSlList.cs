using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD3ZSlList
    {
        public FsD3ZSlList()
        {
            FsD3SankList = new HashSet<FsD3SankList>();
            FsD3SlList = new HashSet<FsD3SlList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD3ZapListid { get; set; }
        public string Idcase { get; set; }
        public string Vidpom { get; set; }
        public string Lpu { get; set; }
        public bool? Vbr { get; set; }
        public DateTime? DateZ1 { get; set; }
        public DateTime? DateZ2 { get; set; }
        public bool? POtk { get; set; }
        public string RsltD { get; set; }
        public bool? OsSluch { get; set; }
        public string Idsp { get; set; }
        public decimal? Sumv { get; set; }
        public string Oplata { get; set; }
        public decimal? Sump { get; set; }
        public decimal? SankIt { get; set; }

        public virtual FsD3ZapList FsD3ZapList { get; set; }
        public virtual ICollection<FsD3SankList> FsD3SankList { get; set; }
        public virtual ICollection<FsD3SlList> FsD3SlList { get; set; }
    }
}
