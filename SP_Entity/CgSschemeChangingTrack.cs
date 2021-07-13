using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class CgSschemeChangingTrack
    {
        public decimal Id { get; set; }
        public decimal SignSchemeId { get; set; }
        public byte[] RawContent { get; set; }
        public byte[] Content { get; set; }
        public DateTime RecordDate { get; set; }
        public decimal Version { get; set; }
        public decimal UserinfoId { get; set; }
    }
}
