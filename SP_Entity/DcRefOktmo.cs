using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefOktmo
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Guid { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Status { get; set; }
        public string Regioncode { get; set; }
        public string Areacode { get; set; }
        public string Citycode { get; set; }
        public string Localcode { get; set; }
        public string Controlnum { get; set; }
        public string Section { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Centrename { get; set; }
        public string Clarification { get; set; }
        public string Lastchangenum { get; set; }
        public string Lastchangetype { get; set; }
        public DateTime? Changedate { get; set; }
        public DateTime? Introductiondate { get; set; }
    }
}
