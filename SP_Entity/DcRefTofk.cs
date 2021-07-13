using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefTofk
    {
        public DcRefTofk()
        {
            FsReasonschangesList = new HashSet<FsReasonschangesList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Guid { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public string Shortname { get; set; }
        public string Fullname { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Addresslegal { get; set; }
        public string TofkcodeCode { get; set; }
        public string TofkcodeShortname { get; set; }
        public DateTime? Opendate { get; set; }
        public DateTime? Closedate { get; set; }
        public string Tofkstatus { get; set; }
        public string Errorinfotext { get; set; }
        public bool? Checkpim { get; set; }
        public string Firstrecguid { get; set; }
        public string Lastrecguid { get; set; }
        public DateTime? Changedate { get; set; }
        public bool? Isuploaded { get; set; }
        public string Telephone { get; set; }
        public string Indeks { get; set; }
        public string Department { get; set; }
        public string Dom { get; set; }
        public string Korp { get; set; }
        public string Kvart { get; set; }
        public string Regionname { get; set; }
        public string Raionname { get; set; }
        public string Gorodname { get; set; }
        public string Naspunktname { get; set; }
        public string Streetname { get; set; }

        public virtual ICollection<FsReasonschangesList> FsReasonschangesList { get; set; }
    }
}
