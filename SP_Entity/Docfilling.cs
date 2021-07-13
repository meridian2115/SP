using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Docfilling
    {
        public decimal Fillingid { get; set; }
        public decimal? Version { get; set; }
        public decimal? Doctypeid { get; set; }
        public decimal? Orgid { get; set; }
        public string Keyname { get; set; }
        public string Fieldname { get; set; }
        public string Fieldvalue { get; set; }
        public decimal? Useforcreate { get; set; }
        public decimal? Useforcopy { get; set; }
        public decimal? Useforpattern { get; set; }
    }
}
