using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcDictContractor
    {
        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public bool? Enabledflag { get; set; }
        public string ShortName { get; set; }
        public string Businessstatecode { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Opf { get; set; }
        public string Address { get; set; }
        public string Resident { get; set; }
    }
}
