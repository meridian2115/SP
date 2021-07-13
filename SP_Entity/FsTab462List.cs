using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTab462List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string NameOfBudget { get; set; }
        public string C2CdTofk { get; set; }
        public string C2Code { get; set; }
        public string Codenottofk { get; set; }
        public string C3Kbk { get; set; }
        public string C3aKbk { get; set; }
        public string C3bKbk { get; set; }
        public string C3cKbk { get; set; }
        public string C3dKbk { get; set; }
        public decimal? C4Sum { get; set; }
        public bool? Logik { get; set; }
        public string G3aNkbk { get; set; }
        public string G3bNkbk { get; set; }
        public string G3cNkbk { get; set; }
        public string G3dNkbk { get; set; }

        public virtual DcArpReport0521462 Doc { get; set; }
    }
}
