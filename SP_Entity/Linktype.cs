using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Linktype
    {
        public decimal Id { get; set; }
        public decimal? Version { get; set; }
        public string Name { get; set; }
        public string Systemname { get; set; }
        public string Inwardname { get; set; }
        public string Outwardname { get; set; }
        public bool? Directed { get; set; }
        public byte[] Inicon { get; set; }
        public byte[] Outicon { get; set; }
        public bool? IsVisible { get; set; }
        public decimal? VisibleByDefault { get; set; }
        public string Inwarddelpolicy { get; set; }
        public string Outwarddelpolicy { get; set; }
        public bool? ReadOnly { get; set; }
    }
}
