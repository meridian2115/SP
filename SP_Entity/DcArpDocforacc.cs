using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpDocforacc
    {
        public DcArpDocforacc()
        {
            FsFieldsdocfahList = new HashSet<FsFieldsdocfahList>();
            FsFieldsdocforaccList = new HashSet<FsFieldsdocforaccList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Docsysname { get; set; }
        public string Docgroup { get; set; }
        public string Doctype { get; set; }
        public string Docname { get; set; }
        public string Docheadtable { get; set; }
        public string Docheadview { get; set; }
        public string Doclinestable { get; set; }
        public string Doclinesview { get; set; }
        public string Docheadtablefah { get; set; }
        public string Doclinestablefah { get; set; }
        public string Counterheadtablefah { get; set; }
        public string Counterlinestablefah { get; set; }
        public string Idheadtablefah { get; set; }
        public string Idheadlinestablefah { get; set; }
        public string Idlinestablefah { get; set; }

        public virtual ICollection<FsFieldsdocfahList> FsFieldsdocfahList { get; set; }
        public virtual ICollection<FsFieldsdocforaccList> FsFieldsdocforaccList { get; set; }
    }
}
