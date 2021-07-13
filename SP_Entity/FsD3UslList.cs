using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD3UslList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD3SlListid { get; set; }
        public string Idserv { get; set; }
        public string Lpu { get; set; }
        public string Lpu1 { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public bool? POtk { get; set; }
        public string CodeUsl { get; set; }
        public decimal? Tarif { get; set; }
        public decimal? SumvUsl { get; set; }
        public string Prvs { get; set; }
        public string CodeMd { get; set; }
        public string Comentu { get; set; }

        public virtual FsD3SlList FsD3SlList { get; set; }
    }
}
