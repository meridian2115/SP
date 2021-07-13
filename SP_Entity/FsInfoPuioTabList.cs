using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsInfoPuioTabList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Docname { get; set; }
        public string Docnumber { get; set; }
        public DateTime? Docdate { get; set; }
        public DateTime? Datenote { get; set; }
        public string Debit { get; set; }
        public string Credit { get; set; }
        public decimal? Sum { get; set; }
        public string HDocType { get; set; }
        public string HDocGuid { get; set; }
        public string Dtype { get; set; }

        public virtual DcArpInfoPuio Doc { get; set; }
    }
}
