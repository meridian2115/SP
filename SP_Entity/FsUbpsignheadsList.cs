using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsUbpsignheadsList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Docid { get; set; }
        public string Headsurname { get; set; }
        public string Headname { get; set; }
        public string Headmiddlename { get; set; }
        public string Headpost { get; set; }
        public string Headinn { get; set; }
        public string Headdocname { get; set; }
        public string Headdocnum { get; set; }
        public DateTime? Headdocdate { get; set; }
        public string Headsnils { get; set; }
        public bool? Headpostflaf { get; set; }

        public virtual DcRefUbpandnubp Doc { get; set; }
    }
}
