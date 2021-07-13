using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DoccontentRep
    {
        public decimal? Version { get; set; }
        public decimal Docid { get; set; }
        public decimal? Senderid { get; set; }
        public decimal? Receiverid { get; set; }
        public decimal? Addinfoid { get; set; }
        public DateTime? Repdate { get; set; }
        public string Reptype { get; set; }
        public string Reptitle { get; set; }
        public string Param { get; set; }
        public DateTime? Repcreatedate { get; set; }
        public string Versionformatdata { get; set; }
        public string Versionformatpattern { get; set; }
        public bool? Qpattern { get; set; }
        public bool? Qdoc { get; set; }
        public string Lasterrorcode { get; set; }
        public string Lasterrormessage { get; set; }
        public string Formname { get; set; }
        public DateTime? Createdate { get; set; }
        public string Executor { get; set; }
        public string Contour { get; set; }
        public string Sourcetype { get; set; }
        public string Sourcecode { get; set; }
        public string Sourcename { get; set; }
        public string Receivertype { get; set; }
        public string Receivercode { get; set; }
        public string Receivername { get; set; }
        public string Period { get; set; }
        public string Documenttype { get; set; }
        public string Doctypename { get; set; }
        public string Financialyear { get; set; }
        public string Recipientguid { get; set; }
        public string Sourceguid { get; set; }
        public string Typeofrecipient { get; set; }
        public string Parameter12 { get; set; }
        public string Intermediate { get; set; }
        public decimal? Docnumberdigits { get; set; }
        public string Account { get; set; }
    }
}
