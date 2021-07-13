using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DemoDocument
    {
        public DemoDocument()
        {
            DemoAttachment2doc = new HashSet<DemoAttachment2doc>();
        }

        public string Guid { get; set; }
        public decimal? Version { get; set; }
        public string Doctypesystemname { get; set; }
        public string Documentinfo { get; set; }
        public byte[] Documentcontent { get; set; }
        public decimal Docid { get; set; }

        public virtual ICollection<DemoAttachment2doc> DemoAttachment2doc { get; set; }
    }
}
