using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Admincontext
    {
        public decimal Contextid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public decimal? Defaultofficetypeid { get; set; }
        public decimal? Defaultcomplextypeid { get; set; }
        public decimal? Defaultorgtypeid { get; set; }
        public decimal? Creditofficetypeid { get; set; }
        public decimal? Creditcomplextypeid { get; set; }
    }
}
