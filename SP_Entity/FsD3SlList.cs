using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD3SlList
    {
        public FsD3SlList()
        {
            FsD3Ds2NList = new HashSet<FsD3Ds2NList>();
            FsD3NazList = new HashSet<FsD3NazList>();
            FsD3UslList = new HashSet<FsD3UslList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD3ZSlListid { get; set; }
        public string SlId { get; set; }
        public string Lpu1 { get; set; }
        public string Nhistory { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Ds1 { get; set; }
        public bool? Ds1Pr { get; set; }
        public bool? DsOnk { get; set; }
        public string PrDN { get; set; }
        public decimal? EdCol { get; set; }
        public decimal? Tarif { get; set; }
        public decimal? SumM { get; set; }
        public string Comentsl { get; set; }

        public virtual FsD3ZSlList FsD3ZSlList { get; set; }
        public virtual ICollection<FsD3Ds2NList> FsD3Ds2NList { get; set; }
        public virtual ICollection<FsD3NazList> FsD3NazList { get; set; }
        public virtual ICollection<FsD3UslList> FsD3UslList { get; set; }
    }
}
