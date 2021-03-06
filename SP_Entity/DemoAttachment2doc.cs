using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DemoAttachment2doc
    {
        public decimal Attachid { get; set; }
        public decimal Docid { get; set; }

        public virtual DemoAttachment Attach { get; set; }
        public virtual DemoDocument Doc { get; set; }
    }
}
