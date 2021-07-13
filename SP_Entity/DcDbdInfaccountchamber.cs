using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdInfaccountchamber
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public string Namefile { get; set; }
        public DateTime? Dateformation { get; set; }
        public DateTime? Dateupload { get; set; }
        public string Sizefile { get; set; }
        public DateTime? Startdateselect { get; set; }
        public DateTime? Enddateselect { get; set; }
    }
}
