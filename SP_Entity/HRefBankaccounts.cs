using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HRefBankaccounts
    {
        public decimal Id { get; set; }
        public string Accountnumber { get; set; }
        public string Bankidcode { get; set; }
        public string Bankname { get; set; }
        public string Bankaddress { get; set; }
        public string Corraccount { get; set; }
        public string Note { get; set; }
    }
}
