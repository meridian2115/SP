using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsT0504102List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string InOss { get; set; }
        public string NameOss { get; set; }
        public string NameEi { get; set; }
        public string CodeEi { get; set; }
        public decimal? Price { get; set; }
        public decimal? Count { get; set; }
        public decimal? Amount { get; set; }
        public string Note { get; set; }
        public string AdressCurrent { get; set; }
        public string OfficeCurrent { get; set; }
        public string AdressNew { get; set; }
        public string OfficeNew { get; set; }
        public string Kvfo { get; set; }
        public string Kppv { get; set; }
        public string KindProperty { get; set; }
        public string TypeMc { get; set; }
        public string KindMc { get; set; }
        public decimal? SummAmort { get; set; }
        public decimal? DValue { get; set; }
        public string KindPropertyNew { get; set; }
        public string TypeMcNew { get; set; }
        public string KindMcNew { get; set; }
        public string Npp { get; set; }

        public virtual DcArpFah05041021 Doc { get; set; }
    }
}
