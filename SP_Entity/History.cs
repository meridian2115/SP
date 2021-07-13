using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class History
    {
        public decimal Id { get; set; }
        public decimal? Version { get; set; }
        public string Username { get; set; }
        public DateTime? Changedate { get; set; }
        public string Globaldocid { get; set; }
        public decimal? Checklevel { get; set; }
        public DateTime? Lastmodifydate { get; set; }
        public string Lastmodifyusername { get; set; }
        public string Lastmodifycomplexname { get; set; }
        public string Destorg { get; set; }
        public DateTime? Lastprintdate { get; set; }
        public bool? Printed { get; set; }
        public decimal? Approvalstate { get; set; }
        public decimal? Priority { get; set; }
        public decimal? Archive { get; set; }
        public string Exportstatus { get; set; }
        public bool? Hasattaches { get; set; }
        public decimal? Attachcount { get; set; }
        public decimal? Totalattachsize { get; set; }
        public decimal? Signcount { get; set; }
        public string Docstate { get; set; }
        public string Owner { get; set; }
        public string Localdocstate { get; set; }
        public string Tag { get; set; }
    }
}
