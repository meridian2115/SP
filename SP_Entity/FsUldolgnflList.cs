using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUldolgnflList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? Dtstart { get; set; }
        public string Grn { get; set; }
        public string Viddolgn { get; set; }
        public string Naimviddolgn { get; set; }
        public string Dolgn { get; set; }
        public string Inn { get; set; }
        public string Telefon { get; set; }
        public string Famfl { get; set; }
        public string Namefl { get; set; }
        public string Otchfl { get; set; }

        public virtual DcRefEgrul Doc { get; set; }
    }
}
