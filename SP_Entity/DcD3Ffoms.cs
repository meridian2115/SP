using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcD3Ffoms
    {
        public DcD3Ffoms()
        {
            FsD3ZapList = new HashSet<FsD3ZapList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public DateTime? Data { get; set; }
        public string Filename { get; set; }
        public decimal? SdZ { get; set; }
        public string SchetCode { get; set; }
        public string SchetCodeMo { get; set; }
        public string SchetYear { get; set; }
        public string SchetMonth { get; set; }
        public string SchetNschet { get; set; }
        public DateTime? SchetDschet { get; set; }
        public string SchetPlat { get; set; }
        public decimal? SchetSummav { get; set; }
        public string SchetComents { get; set; }
        public decimal? SchetSummap { get; set; }
        public string SchetSankMek { get; set; }
        public string SchetSankMee { get; set; }
        public string SchetSankEkmp { get; set; }
        public string SchetDisp { get; set; }

        public virtual ICollection<FsD3ZapList> FsD3ZapList { get; set; }
    }
}
