using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsRtTablsubsidList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Coderegis { get; set; }
        public string Numberaccount { get; set; }
        public string Nmbrbnkaccnt { get; set; }
        public string Namebnk { get; set; }
        public string Bikbnk { get; set; }
        public string Correspndntaccnt { get; set; }
        public string Uniccodeorg { get; set; }

        public virtual DcExpInfbo Doc { get; set; }
    }
}
