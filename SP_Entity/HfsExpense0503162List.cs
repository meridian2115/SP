using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsExpense0503162List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1S1 { get; set; }
        public string C1aS1 { get; set; }
        public string C1bS1 { get; set; }
        public string C1cS1 { get; set; }
        public string C1dS1 { get; set; }
        public string C1eS1 { get; set; }
        public string C2S1 { get; set; }
        public string C2aS1 { get; set; }
        public string C3S1 { get; set; }
        public decimal? C4S1 { get; set; }
        public decimal? C5S1 { get; set; }
        public decimal? C6S1 { get; set; }
        public decimal? C7S1 { get; set; }

        public virtual HReport0503162 IdNavigation { get; set; }
    }
}
