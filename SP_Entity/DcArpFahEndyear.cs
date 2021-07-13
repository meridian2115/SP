using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFahEndyear
    {
        public DcArpFahEndyear()
        {
            FsEndyearList = new HashSet<FsEndyearList>();
            FsLinkdocendList = new HashSet<FsLinkdocendList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string PTofkCode { get; set; }
        public string FinYear { get; set; }
        public string Budget { get; set; }
        public string BudgetCode { get; set; }
        public string PUfosGuid { get; set; }
        public string PFormatRtf { get; set; }
        public string PFormatTxt { get; set; }
        public string PFormatPdf { get; set; }
        public string PFormatExl { get; set; }
        public string PXmlFormat { get; set; }
        public DateTime? PFirstWorkday { get; set; }
        public string XErrbuf { get; set; }
        public string Inst { get; set; }
        public string PYear { get; set; }
        public string Npp { get; set; }

        public virtual ICollection<FsEndyearList> FsEndyearList { get; set; }
        public virtual ICollection<FsLinkdocendList> FsLinkdocendList { get; set; }
    }
}
