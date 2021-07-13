using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcFamInformesD31
    {
        public DcFamInformesD31()
        {
            FsEslistD31List = new HashSet<FsEslistD31List>();
            FsVerificprotocolD31List = new HashSet<FsVerificprotocolD31List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string BreEdno { get; set; }
        public DateTime? BreEddate { get; set; }
        public string BreEdauthor { get; set; }
        public string BreEdreceiver { get; set; }
        public string BreDocguid { get; set; }
        public decimal? PiPartnumber { get; set; }
        public decimal? PiPartquantity { get; set; }
        public string PiPartcomplexuid { get; set; }
        public string EsisEdno { get; set; }
        public DateTime? EsisEddate { get; set; }
        public string EsisEdauthor { get; set; }
        public string EsisEstype { get; set; }
        public string EsisReqstatus { get; set; }
        public string EsisReqcode { get; set; }
        public string EsisReqname { get; set; }
        public DateTime? EsisReqdatedoc { get; set; }
        public string EsisDocguid { get; set; }
        public string EsEdno { get; set; }
        public DateTime? EsEddate { get; set; }
        public string EsEdauthor { get; set; }
        public string TfVerificprotocolst { get; set; }
        public string TfFilename { get; set; }
        public string TfTofkcode { get; set; }
        public string TfTofkname { get; set; }

        public virtual ICollection<FsEslistD31List> FsEslistD31List { get; set; }
        public virtual ICollection<FsVerificprotocolD31List> FsVerificprotocolD31List { get; set; }
    }
}
