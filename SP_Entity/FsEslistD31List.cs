using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsEslistD31List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Edno { get; set; }
        public DateTime? Eddate { get; set; }
        public string Edauthor { get; set; }
        public string Edtype { get; set; }
        public string Edtypename { get; set; }
        public DateTime? Edprocessingtime { get; set; }
        public string Filename { get; set; }

        public virtual DcFamInformesD31 Doc { get; set; }
    }
}
