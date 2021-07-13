using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsNotiflistnsi011List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string Packageguid { get; set; }
        public string Doctype { get; set; }
        public string Doctypenm { get; set; }
        public DateTime? Notifdate { get; set; }
        public string Notifstat { get; set; }
        public string Notifguid { get; set; }
        public string Controlmsg { get; set; }
        public string Paydocnum { get; set; }
        public DateTime? Paydocdate { get; set; }
        public string Paydocguid { get; set; }
        public string Paydocguidedi { get; set; }
        public string RCheckacc { get; set; }
        public string PCheckacc { get; set; }
        public string PBik { get; set; }
        public string Direction { get; set; }
        public DateTime? Datetimechangestat { get; set; }
        public string Notifpkgstat { get; set; }
        public string FileName { get; set; }
        public DateTime? Dictdate { get; set; }
        public string Dictstatus { get; set; }

        public virtual DcNsi011Journaljkhandgmp Doc { get; set; }
    }
}
