using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcKsSetProtokol
    {
        public DcKsSetProtokol()
        {
            FsSetFieldKsList = new HashSet<FsSetFieldKsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Codereportform { get; set; }
        public string Namereportform { get; set; }
        public string Formsystemname { get; set; }
        public string TdSystemnamefield { get; set; }
        public string TdNamefield { get; set; }
        public string TdSection { get; set; }
        public string TdClmn { get; set; }
        public string TdLinenumber { get; set; }
        public string TdContentrow { get; set; }
        public string TdTypecontentrow { get; set; }
        public string TdDocfield { get; set; }
        public string TdDoctable { get; set; }
        public string TdTablenamefield { get; set; }
        public string TdTablefilednumbercolum { get; set; }
        public string TdFormsystemname { get; set; }
        public string TdLevel1 { get; set; }
        public string TdLevel2 { get; set; }
        public string TdNote { get; set; }
        public string TdFieldType { get; set; }
        public string TdFieldTypeLit { get; set; }

        public virtual ICollection<FsSetFieldKsList> FsSetFieldKsList { get; set; }
    }
}
