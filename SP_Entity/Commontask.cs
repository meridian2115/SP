using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Commontask
    {
        public decimal Taskid { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public decimal? Enabled { get; set; }
        public decimal? Useparent { get; set; }
        public decimal? Usecalendar { get; set; }
        public string Servername { get; set; }
        public string Priority { get; set; }
    }
}
