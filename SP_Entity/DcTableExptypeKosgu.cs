using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcTableExptypeKosgu
    {
        public DcTableExptypeKosgu()
        {
            FsKosguList = new HashSet<FsKosguList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Segment1 { get; set; }
        public string ExpensesTypesName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<FsKosguList> FsKosguList { get; set; }
    }
}
