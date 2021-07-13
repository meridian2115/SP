using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUlobList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public DateTime? Dtstart { get; set; }
        public string Grn { get; set; }
        public string Vidob { get; set; }
        public string Namep { get; set; }
        public string Indeks { get; set; }
        public string Regioncode { get; set; }
        public string Kladr { get; set; }
        public string Dom { get; set; }
        public string Korp { get; set; }
        public string Kvart { get; set; }
        public string Regiontype { get; set; }
        public string Regionname { get; set; }
        public string Raiontype { get; set; }
        public string Raionname { get; set; }
        public string Gorodtype { get; set; }
        public string Gorodname { get; set; }
        public string Naspunkttype { get; set; }
        public string Naspunktname { get; set; }
        public string Streettype { get; set; }
        public string Streetname { get; set; }
        public string Oksmcode { get; set; }
        public string Oksmname { get; set; }
        public string Foreignaddress { get; set; }
        public DateTime? UfDtreg { get; set; }
        public string Orgkpp { get; set; }

        public virtual DcRefEgrul Doc { get; set; }
    }
}
