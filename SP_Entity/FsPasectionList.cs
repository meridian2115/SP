using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsPasectionList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Guid { get; set; }
        public string Acodesection { get; set; }
        public string Bstatussectionls { get; set; }
        public DateTime? Sectionopendate { get; set; }
        public DateTime? Sectionclosedate { get; set; }
        public string Basenumdoc { get; set; }
        public DateTime? Basedatedoc { get; set; }
        public string Subjectagreement { get; set; }
        public string Basetypedoc { get; set; }
        public string Basedocguid { get; set; }
        public string Numregistryrecord { get; set; }

        public virtual DcRefPersaccount Doc { get; set; }
    }
}
