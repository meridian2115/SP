using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class BuildItem
    {
        public decimal ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? BuildId { get; set; }
        public string ItemDescription { get; set; }
        public string LoadStatus { get; set; }
    }
}
