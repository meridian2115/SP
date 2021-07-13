using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class SystemConst
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Version { get; set; }
        public decimal? Orgid { get; set; }
        public decimal? Typeid { get; set; }
        public decimal? Userid { get; set; }
        public string Prevvalue { get; set; }
        public string Username { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
