using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdTab6Svodfz
    {
        public DcDbdTab6Svodfz()
        {
            FsTablepartSummarytableList = new HashSet<FsTablepartSummarytableList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string TitlepartYear { get; set; }
        public decimal? TablepartSt3S { get; set; }
        public decimal? TablepartSt4S { get; set; }
        public decimal? TablepartSt5S { get; set; }
        public decimal? TablepartSt6S { get; set; }
        public decimal? TablepartSt7S { get; set; }
        public decimal? TablepartSt8S { get; set; }
        public decimal? TablepartSt9S { get; set; }
        public decimal? TablepartSt10S { get; set; }
        public decimal? TablepartSt11S { get; set; }
        public decimal? TablepartSt12S { get; set; }
        public decimal? TablepartSt13S { get; set; }

        public virtual ICollection<FsTablepartSummarytableList> FsTablepartSummarytableList { get; set; }
    }
}
