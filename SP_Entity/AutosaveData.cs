using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class AutosaveData
    {
        public decimal Id { get; set; }
        public decimal? Version { get; set; }
        public string Docguid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Orgid { get; set; }
        public decimal? Doctypeid { get; set; }
        public string Docinfo { get; set; }
        public DateTime? Changedate { get; set; }
        public byte[] Documentdata { get; set; }

        public virtual Doctype Doctype { get; set; }
        public virtual Org Org { get; set; }
        public virtual Userinfo User { get; set; }
    }
}
