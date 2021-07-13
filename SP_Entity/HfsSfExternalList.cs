using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsSfExternalList
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C1R6201 { get; set; }
        public string C2R6201 { get; set; }
        public string C3R6201 { get; set; }
        public string C3aR6201 { get; set; }
        public string C3bR6201 { get; set; }
        public decimal? C4R6201 { get; set; }
        public decimal? C5R6201 { get; set; }
        public decimal? C6R6201 { get; set; }
        public decimal? C7R6201 { get; set; }
        public decimal? C8R6201 { get; set; }
        public decimal? C9R6201 { get; set; }

        public virtual HReport0503127 IdNavigation { get; set; }
    }
}
