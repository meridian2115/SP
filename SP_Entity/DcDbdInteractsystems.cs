using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDbdInteractsystems
    {
        public DcDbdInteractsystems()
        {
            FsInteractsystemsList = new HashSet<FsInteractsystemsList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Docsystemname { get; set; }
        public string Docname { get; set; }
        public string Grbscode { get; set; }
        public string Numbls { get; set; }
        public string Patype { get; set; }
        public string Mastersystem { get; set; }
        public DateTime? PeriodStartdate { get; set; }
        public DateTime? PeriodEnddate { get; set; }
        public string SiTfGuid { get; set; }
        public string SiTfDocstate { get; set; }
        public string SiTfOrgsysname { get; set; }
        public string SiTfTransferstate { get; set; }
        public string SiTfTransfererror { get; set; }
        public string SiTfClientstate { get; set; }
        public string SiTfBodid { get; set; }
        public string SiTfAsfkstate { get; set; }
        public DateTime? Datechange { get; set; }
        public string TofkName { get; set; }
        public string TofkCode { get; set; }

        public virtual ICollection<FsInteractsystemsList> FsInteractsystemsList { get; set; }
    }
}
