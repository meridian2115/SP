using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DwSprBroTitle
    {
        public string DocUuid { get; set; }
        public decimal? IsTotal { get; set; }
        public decimal? Accesslevel { get; set; }
        public decimal? IsMigration { get; set; }
        public string DateUtv { get; set; }
        public DateTime DateOt { get; set; }
        public string CodeGrbs { get; set; }
        public string NameGrbs { get; set; }
        public string CodeDep { get; set; }
        public string NameDep { get; set; }
        public string CodeVid { get; set; }
        public string NameVid { get; set; }
        public string Osn { get; set; }
        public string Question { get; set; }
        public string DopInf { get; set; }
        public DateTime? DateReg { get; set; }
    }
}
