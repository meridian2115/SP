using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class RplSentObject
    {
        public decimal Id { get; set; }
        public decimal Version { get; set; }
        public decimal Complexid { get; set; }
        public decimal? Localrplversion { get; set; }
        public decimal? Dicttypeid { get; set; }
        public DateTime? SendDate { get; set; }
    }
}
