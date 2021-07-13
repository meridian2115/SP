using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefEgrul
    {
        public DcRefEgrul()
        {
            FsUldolgnflList = new HashSet<FsUldolgnflList>();
            FsUlobList = new HashSet<FsUlobList>();
            FsUlokvedList = new HashSet<FsUlokvedList>();
            FsUlpredshList = new HashSet<FsUlpredshList>();
            FsUlpreemList = new HashSet<FsUlpreemList>();
            FsUlregactList = new HashSet<FsUlregactList>();
            FsUlregactsvsvList = new HashSet<FsUlregactsvsvList>();
            FsUlregnonactList = new HashSet<FsUlregnonactList>();
            FsUlregnonactsvsvList = new HashSet<FsUlregnonactsvsvList>();
            FsUlrulList = new HashSet<FsUlrulList>();
            FsUluchrrfList = new HashSet<FsUluchrrfList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Iddok { get; set; }
        public string Ogrn { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public DateTime? Dtstartmns { get; set; }
        public DateTime? UnDtstart { get; set; }
        public string UnGrn { get; set; }
        public string UnNamep { get; set; }
        public string UnNames { get; set; }
        public string UnNamef { get; set; }
        public string UnOpfspr { get; set; }
        public string UnKodopf { get; set; }
        public string UnNameopf { get; set; }
        public DateTime? UaDtstart { get; set; }
        public string UaGrn { get; set; }
        public string UaAddrind { get; set; }
        public string UaIndeks { get; set; }
        public string UaRegioncode { get; set; }
        public string UaKladr { get; set; }
        public string UaDom { get; set; }
        public string UaKorp { get; set; }
        public string UaKvart { get; set; }
        public string UaRegiontype { get; set; }
        public string UaRegionname { get; set; }
        public string UaRaiontype { get; set; }
        public string UaRaionname { get; set; }
        public string UaGorodtype { get; set; }
        public string UaGorodname { get; set; }
        public string UaNaspunkttype { get; set; }
        public string UaNaspunktname { get; set; }
        public string UaStreettype { get; set; }
        public string UaStreetname { get; set; }
        public DateTime? UsDtstart { get; set; }
        public string UsGrn { get; set; }
        public string UsStatusid { get; set; }
        public string UsNamestatus { get; set; }
        public DateTime? UbDtstart { get; set; }
        public string UbGrn { get; set; }
        public DateTime? UbDtreg { get; set; }
        public string UbVidregid { get; set; }
        public string UbVidregname { get; set; }
        public DateTime? UfDtstart { get; set; }
        public string UfGrn { get; set; }
        public DateTime? UfDtreg { get; set; }
        public string UfVidregid { get; set; }
        public string UfVidregname { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Status { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<FsUldolgnflList> FsUldolgnflList { get; set; }
        public virtual ICollection<FsUlobList> FsUlobList { get; set; }
        public virtual ICollection<FsUlokvedList> FsUlokvedList { get; set; }
        public virtual ICollection<FsUlpredshList> FsUlpredshList { get; set; }
        public virtual ICollection<FsUlpreemList> FsUlpreemList { get; set; }
        public virtual ICollection<FsUlregactList> FsUlregactList { get; set; }
        public virtual ICollection<FsUlregactsvsvList> FsUlregactsvsvList { get; set; }
        public virtual ICollection<FsUlregnonactList> FsUlregnonactList { get; set; }
        public virtual ICollection<FsUlregnonactsvsvList> FsUlregnonactsvsvList { get; set; }
        public virtual ICollection<FsUlrulList> FsUlrulList { get; set; }
        public virtual ICollection<FsUluchrrfList> FsUluchrrfList { get; set; }
    }
}
