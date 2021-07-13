using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefInstitutions
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public string Shortname { get; set; }
        public string Type { get; set; }
        public decimal? OrfkId { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string Cdrsnrg { get; set; }
        public string Cdnceo { get; set; }
        public string Nmelpublglstr { get; set; }
        public string Address { get; set; }
        public bool? Recbudg { get; set; }
        public bool? Othrecbudg { get; set; }
        public bool? Cabr { get; set; }
        public bool? Abr { get; set; }
        public bool? Caisfbd { get; set; }
        public bool? Caesfbd { get; set; }
        public bool? Aisfbd { get; set; }
        public bool? Aesfbd { get; set; }
        public bool? Tmpmngrbdgt { get; set; }
        public string Note { get; set; }
        public bool? Finorg { get; set; }
        public bool? Detachedsubdivision { get; set; }
        public bool? Sobf { get; set; }
        public bool? Tsobf { get; set; }
    }
}
