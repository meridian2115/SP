using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class LogFiscaljournal
    {
        public decimal Eventid { get; set; }
        public decimal Eventtypeid { get; set; }
        public decimal Docid { get; set; }
        public string Docguid { get; set; }
        public decimal Doctypeid { get; set; }
        public string Orgsystemname { get; set; }
        public string Usersystemname { get; set; }
        public string Info { get; set; }
        public decimal Docstateid { get; set; }
        public string Complexglobalid { get; set; }
        public string Remoteaddressip { get; set; }
        public string Sessionid { get; set; }
        public string Details { get; set; }
        public DateTime? Eventstartdate { get; set; }
        public DateTime? Eventfinishdate { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal? ParentRecordId { get; set; }
        public decimal? RowNum { get; set; }
        public string CheckResult { get; set; }
        public string Serveraddressip { get; set; }
    }
}
