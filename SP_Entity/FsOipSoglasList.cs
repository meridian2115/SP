using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsOipSoglasList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Role { get; set; }
        public string Codeorder { get; set; }
        public string Codegroup { get; set; }
        public string Grouporder { get; set; }
        public string Typeagreement { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Resolution { get; set; }
        public string Position { get; set; }
        public string Note { get; set; }
        public string Department { get; set; }

        public virtual DcArpSoglas Doc { get; set; }
    }
}
