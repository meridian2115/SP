using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsReAssigneeList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Nmbr { get; set; }
        public bool? IsEmpty { get; set; }
        public string Csr { get; set; }
        public string Name { get; set; }
        public string CdSubrep { get; set; }
        public string NameSubrep { get; set; }
        public string CdGlavaBk { get; set; }
        public string NameGlavaBk { get; set; }
        public string CdOktmo { get; set; }
        public string NameOktmo { get; set; }
        public string Note { get; set; }

        public virtual DcSubjectsReporting Doc { get; set; }
    }
}
