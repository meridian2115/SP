using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsXmlFilesList
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public decimal? FileDocId { get; set; }
        public string FileName { get; set; }
        public DateTime? CreationDate { get; set; }
        public string FormatCode { get; set; }
        public string BankBik { get; set; }
        public string XmlFile { get; set; }

        public virtual DcFamRegofpaymentsD05 Doc { get; set; }
    }
}
