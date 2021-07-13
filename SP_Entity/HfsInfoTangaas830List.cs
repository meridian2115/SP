using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsInfoTangaas830List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public string C2R0201 { get; set; }
        public decimal? C4R0201 { get; set; }
        public decimal? C5R0201 { get; set; }
        public decimal? C6R0201 { get; set; }
        public decimal? C7R0201 { get; set; }
        public decimal? C8R0201 { get; set; }
        public decimal? C9R0201 { get; set; }
        public decimal? C10R0201 { get; set; }
        public decimal? C11R0201 { get; set; }

        public virtual HArprep0503830 IdNavigation { get; set; }
    }
}
