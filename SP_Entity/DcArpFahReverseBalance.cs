﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahReverseBalance
    {
        public DcArpFahReverseBalance()
        {
            FsAcconeRbList = new HashSet<FsAcconeRbList>();
            FsErrorrbList = new HashSet<FsErrorrbList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? DateForm { get; set; }
        public string Tofk { get; set; }
        public string NameTofk { get; set; }
        public string Stat { get; set; }
        public string Phase { get; set; }
        public string TextCompletion { get; set; }
        public string Instcd { get; set; }
        public string Npp { get; set; }
        public string CancelComment { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public string PUfosGuid { get; set; }
        public DateTime? PReportDate { get; set; }
        public string CdBudget { get; set; }
        public string TypeDoc { get; set; }
        public string Nmaccrec { get; set; }
        public string Nmaccrec1 { get; set; }
        public string OperFt { get; set; }
        public string BudFt { get; set; }

        public virtual ICollection<FsAcconeRbList> FsAcconeRbList { get; set; }
        public virtual ICollection<FsErrorrbList> FsErrorrbList { get; set; }
    }
}
