using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpbankaccountsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Bankaccountnum { get; set; }
        public string Bankname { get; set; }
        public string Bankcorraccount { get; set; }
        public string Bankbik { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
