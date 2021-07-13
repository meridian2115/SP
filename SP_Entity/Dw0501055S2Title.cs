using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Dw0501055S2Title
    {
        public Guid DocUuid { get; set; }
        public string NumRef { get; set; }
        public string DateUtv { get; set; }
        public DateTime? DateOt { get; set; }
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
        public short? IsTotal { get; set; }
        public short? Accesslevel { get; set; }
        public short? IsMigration { get; set; }
        public string OkudCode { get; set; }
        public string NumResh { get; set; }
        public string NoteFilename { get; set; }
        public decimal? FinYear { get; set; }
    }
}
