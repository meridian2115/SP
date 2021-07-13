using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpsuccessionsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Succogrn { get; set; }
        public string Succname { get; set; }
        public string Succdocname { get; set; }
        public string Succdocnum { get; set; }
        public DateTime? Succdocdate { get; set; }
        public string Datasource { get; set; }
        public string Succcode { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
