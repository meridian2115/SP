using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2UslList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2SlListid { get; set; }
        public string Idserv { get; set; }
        public string Lpu { get; set; }
        public string Lpu1 { get; set; }
        public string Podr { get; set; }
        public string Profil { get; set; }
        public string VidVme { get; set; }
        public bool? Det { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string Ds { get; set; }
        public string CodeUsl { get; set; }
        public decimal? KolUsl { get; set; }
        public decimal? Tarif { get; set; }
        public decimal? SumvUsl { get; set; }
        public string Prvs { get; set; }
        public string CodeMd { get; set; }
        public string Comentu { get; set; }

        public virtual FsD2SlList FsD2SlList { get; set; }
    }
}
