using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Historydoclog
    {
        public decimal Eventid { get; set; }
        public string Name { get; set; }
        public DateTime? Eventdate { get; set; }
        public decimal? Docid { get; set; }
        public decimal? Oldstateid { get; set; }
        public decimal? Newstateid { get; set; }
        public decimal? Userid { get; set; }
    }
}
