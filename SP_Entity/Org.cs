using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class Org
    {
        public Org()
        {
            AutosaveData = new HashSet<AutosaveData>();
            Doc = new HashSet<Doc>();
            Routecontext = new HashSet<Routecontext>();
        }

        public decimal Orgid { get; set; }
        public decimal? Version { get; set; }
        public string Systemname { get; set; }
        public string Name { get; set; }
        public string Externalsystemid { get; set; }
        public bool? Locked { get; set; }
        public bool? Thickclient { get; set; }
        public bool? Webclient { get; set; }
        public bool? Phoneclient { get; set; }
        public bool? Localclient { get; set; }
        public decimal? Remotecomplexid { get; set; }
        public decimal? Orggroupid { get; set; }
        public decimal? Orgdataid { get; set; }
        public string Globaldicid { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public char IsArchive { get; set; }
        public string Username { get; set; }
        public decimal? Parentid { get; set; }
        public string String1 { get; set; }
        public string String2 { get; set; }
        public string String3 { get; set; }
        public string String4 { get; set; }
        public string String5 { get; set; }
        public string String6 { get; set; }
        public string String7 { get; set; }
        public string String8 { get; set; }
        public DateTime? LastSyncDate { get; set; }

        public virtual ICollection<AutosaveData> AutosaveData { get; set; }
        public virtual ICollection<Doc> Doc { get; set; }
        public virtual ICollection<Routecontext> Routecontext { get; set; }
    }
}
