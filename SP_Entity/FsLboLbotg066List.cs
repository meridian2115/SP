using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsLboLbotg066List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Grbscode { get; set; }
        public decimal? TsygYear { get; set; }
        public decimal? TsygYear1 { get; set; }
        public decimal? TsygYear2 { get; set; }

        public virtual DcDbdDecchange Doc { get; set; }
    }
}
