using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Adminsubmenu
    {
        public decimal Adminsubmenuid { get; set; }
        public string Systemname { get; set; }
        public string Name { get; set; }
        public decimal? Adminserviceid { get; set; }
        public string PathToIcon { get; set; }
        public string PathToComponent { get; set; }
        public decimal SecurityRequired { get; set; }
        public decimal Defaultvisible { get; set; }
    }
}
