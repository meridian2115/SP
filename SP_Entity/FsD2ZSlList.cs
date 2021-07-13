﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsD2ZSlList
    {
        public FsD2ZSlList()
        {
            FsD2SankList = new HashSet<FsD2SankList>();
            FsD2SlList = new HashSet<FsD2SlList>();
        }

        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? FsD2ZapListid { get; set; }
        public string Idcase { get; set; }
        public string UslOk { get; set; }
        public string Vidpom { get; set; }
        public string ForPom { get; set; }
        public string NprMo { get; set; }
        public DateTime? NprDate { get; set; }
        public string Lpu { get; set; }
        public DateTime? DateZ1 { get; set; }
        public DateTime? DateZ2 { get; set; }
        public string KdZ { get; set; }
        public decimal? VnovM { get; set; }
        public string Rslt { get; set; }
        public string Ishod { get; set; }
        public bool? OsSluch { get; set; }
        public string Idsp { get; set; }
        public decimal? Sumv { get; set; }
        public string Oplata { get; set; }
        public decimal? Sump { get; set; }
        public decimal? SankIt { get; set; }

        public virtual FsD2ZapList FsD2ZapList { get; set; }
        public virtual ICollection<FsD2SankList> FsD2SankList { get; set; }
        public virtual ICollection<FsD2SlList> FsD2SlList { get; set; }
    }
}