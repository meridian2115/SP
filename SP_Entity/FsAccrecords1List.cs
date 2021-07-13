using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsAccrecords1List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Nmoper { get; set; }
        public DateTime? Dateof { get; set; }
        public string Dtacc { get; set; }
        public string Ctacc { get; set; }
        public decimal? Summ { get; set; }
        public string StatusDescription { get; set; }
        public string StatusDescriptionCopy { get; set; }

        public virtual DcArpFah0504833 Doc { get; set; }
    }
}
