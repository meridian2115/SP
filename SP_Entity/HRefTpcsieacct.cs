using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefTpcsieacct
    {
        public decimal Id { get; set; }
        public string AcctCdGuid { get; set; }
        public string TpCsieCd { get; set; }
        public bool? Ti { get; set; }
        public bool? Bi { get; set; }
        public bool? Ai { get; set; }
        public string Note { get; set; }
    }
}
