using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD4SlList
    {
        public FsD4SlList()
        {
            FsD4ConsList = new HashSet<FsD4ConsList>();
            FsD4KsgKpgList = new HashSet<FsD4KsgKpgList>();
            FsD4NaprList = new HashSet<FsD4NaprList>();
            FsD4OnkSlList = new HashSet<FsD4OnkSlList>();
            FsD4UslList = new HashSet<FsD4UslList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD4ZSlListid { get; set; }
        public string SlId { get; set; }
        public string Lpu1 { get; set; }
        public string Podr { get; set; }
        public string Profil { get; set; }
        public string ProfilK { get; set; }
        public bool? Det { get; set; }
        public string PCel { get; set; }
        public string Nhistory { get; set; }
        public bool? PPer { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Kd { get; set; }
        public string Ds0 { get; set; }
        public string Ds1 { get; set; }
        public string Ds2 { get; set; }
        public string Ds3 { get; set; }
        public string CZab { get; set; }
        public bool? DsOnk { get; set; }
        public string Dn { get; set; }
        public string CodeMes1 { get; set; }
        public string CodeMes2 { get; set; }
        public bool? Reab { get; set; }
        public string Prvs { get; set; }
        public string VersSpec { get; set; }
        public string Iddokt { get; set; }
        public decimal? EdCol { get; set; }
        public decimal? Tarif { get; set; }
        public decimal? SumM { get; set; }
        public string Comentsl { get; set; }

        public virtual FsD4ZSlList FsD4ZSlList { get; set; }
        public virtual ICollection<FsD4ConsList> FsD4ConsList { get; set; }
        public virtual ICollection<FsD4KsgKpgList> FsD4KsgKpgList { get; set; }
        public virtual ICollection<FsD4NaprList> FsD4NaprList { get; set; }
        public virtual ICollection<FsD4OnkSlList> FsD4OnkSlList { get; set; }
        public virtual ICollection<FsD4UslList> FsD4UslList { get; set; }
    }
}
