using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2SlList
    {
        public FsD2SlList()
        {
            FsD2ConsList = new HashSet<FsD2ConsList>();
            FsD2NaprList = new HashSet<FsD2NaprList>();
            FsD2OnkSlList = new HashSet<FsD2OnkSlList>();
            FsD2UslList = new HashSet<FsD2UslList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2ZSlListid { get; set; }
        public string SlId { get; set; }
        public string VidHmp { get; set; }
        public string MetodHmp { get; set; }
        public string Lpu1 { get; set; }
        public string Podr { get; set; }
        public string Profil { get; set; }
        public string ProfilK { get; set; }
        public bool? Det { get; set; }
        public DateTime? TalD { get; set; }
        public string TalNum { get; set; }
        public DateTime? TalP { get; set; }
        public string Nhistory { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Ds0 { get; set; }
        public string Ds1 { get; set; }
        public string Ds2 { get; set; }
        public string Ds3 { get; set; }
        public string CZab { get; set; }
        public bool? DsOnk { get; set; }
        public string CodeMes1 { get; set; }
        public string CodeMes2 { get; set; }
        public string Prvs { get; set; }
        public string VersSpec { get; set; }
        public string Iddokt { get; set; }
        public decimal? EdCol { get; set; }
        public decimal? Tarif { get; set; }
        public decimal? SumM { get; set; }
        public string Comentsl { get; set; }

        public virtual FsD2ZSlList FsD2ZSlList { get; set; }
        public virtual ICollection<FsD2ConsList> FsD2ConsList { get; set; }
        public virtual ICollection<FsD2NaprList> FsD2NaprList { get; set; }
        public virtual ICollection<FsD2OnkSlList> FsD2OnkSlList { get; set; }
        public virtual ICollection<FsD2UslList> FsD2UslList { get; set; }
    }
}
