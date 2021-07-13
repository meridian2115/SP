using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReport0503162
    {
        public HReport0503162()
        {
            HfsExpense0503162List = new HashSet<HfsExpense0503162List>();
        }

        public decimal Id { get; set; }
        public decimal? ResultsC5S2 { get; set; }
        public decimal? ResultsC7S2 { get; set; }
        public decimal? ResultsC5S3 { get; set; }
        public decimal? ResultsC7S3 { get; set; }

        public virtual ICollection<HfsExpense0503162List> HfsExpense0503162List { get; set; }
    }
}
