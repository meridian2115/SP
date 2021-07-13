using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Fs801Accrecords1List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Nmoper { get; set; }
        public DateTime? Dateof { get; set; }
        public string Dtacc { get; set; }
        public string Ctacc { get; set; }
        public decimal? Summ { get; set; }
        public string Status { get; set; }
        public string Tofkcd { get; set; }

        public virtual DcMscApplcashflow Doc { get; set; }
    }
}
