using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahRegistres
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Okud { get; set; }
        public string Name { get; set; }
        public string Formular { get; set; }
        public bool? Mounth { get; set; }
        public bool? God { get; set; }
        public bool? Proizv { get; set; }
        public bool? Day { get; set; }
        public bool? Reorg { get; set; }
        public string Note { get; set; }
        public DateTime? DataStartactive { get; set; }
        public DateTime? DataEndactive { get; set; }
        public string PrFormPrCode { get; set; }
        public string PrFormPrOkud { get; set; }
        public string PrFormPrName { get; set; }
        public string Temp1 { get; set; }
        public string Temp2 { get; set; }
        public string Temp3 { get; set; }
        public string Temp4 { get; set; }
        public string Temp5 { get; set; }
        public string Period { get; set; }
    }
}
