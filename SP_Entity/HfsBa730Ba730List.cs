using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HfsBa730Ba730List
    {
        public decimal Fieldsetid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal? Id { get; set; }
        public decimal? C4Ba { get; set; }
        public decimal? C5Ba { get; set; }
        public decimal? C6Ba { get; set; }
        public decimal? C7Ba { get; set; }
        public decimal? C8Ba { get; set; }
        public decimal? C9Ba { get; set; }
        public decimal? C10Ba { get; set; }
        public decimal? C11Ba { get; set; }

        public virtual HArpReport05037302019 IdNavigation { get; set; }
    }
}
