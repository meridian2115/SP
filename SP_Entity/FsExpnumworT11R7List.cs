using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsExpnumworT11R7List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string C1R7N { get; set; }
        public string C2R7N { get; set; }
        public string C3R7N { get; set; }
        public string C4R7N { get; set; }
        public decimal? C5R7N { get; set; }
        public decimal? C6R7N { get; set; }
        public decimal? C7R7N { get; set; }
        public decimal? C8R7N { get; set; }
        public decimal? C9R7N { get; set; }
        public decimal? C10R7N { get; set; }
        public string C3R7N0 { get; set; }
        public string C3R7N00 { get; set; }

        public virtual DcArpReport05030742018 Doc { get; set; }
    }
}
