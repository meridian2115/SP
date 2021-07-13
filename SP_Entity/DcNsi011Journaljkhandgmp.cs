using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcNsi011Journaljkhandgmp
    {
        public DcNsi011Journaljkhandgmp()
        {
            FsNotiflistnsi011List = new HashSet<FsNotiflistnsi011List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Id { get; set; }
        public string BreDocnum { get; set; }
        public DateTime? BreDocdate { get; set; }
        public string BreDocguid { get; set; }
        public string BreCreateorg { get; set; }
        public string BreCheckacc { get; set; }
        public string BreTofkcode { get; set; }
        public string BreGistype { get; set; }
        public string Login { get; set; }

        public virtual ICollection<FsNotiflistnsi011List> FsNotiflistnsi011List { get; set; }
    }
}
