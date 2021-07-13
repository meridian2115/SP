using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefPersaccount
    {
        public DcRefPersaccount()
        {
            FsPaletterinfoList = new HashSet<FsPaletterinfoList>();
            FsPasectionList = new HashSet<FsPasectionList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Guid { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Status { get; set; }
        public string Persaccounttype { get; set; }
        public string Opentofkregcode { get; set; }
        public string Budgtype { get; set; }
        public string Uchetnum { get; set; }
        public string Controlnum { get; set; }
        public string Persaccountnum { get; set; }
        public string Clientcode { get; set; }
        public string Orgcode { get; set; }
        public string Ownerfullname { get; set; }
        public string Ownershortname { get; set; }
        public string Contourtype { get; set; }
        public string Operationcontour { get; set; }
        public DateTime? Opendate { get; set; }
        public DateTime? Closedate { get; set; }
        public string Persaccntstatus { get; set; }
        public string Recordguid { get; set; }
        public string Kbkglavacode { get; set; }
        public string Kbkglavaname { get; set; }
        public string GuidSed { get; set; }
        public string Accschemecode { get; set; }
        public string Accschemename { get; set; }
        public string Errorinfotext { get; set; }
        public bool? Checkpim { get; set; }
        public DateTime? Startdateb { get; set; }
        public DateTime? Enddateb { get; set; }
        public string Accountorgcode { get; set; }
        public string Accountorgfullname { get; set; }
        public string Codeppooktmo { get; set; }
        public string Nameppooktmo { get; set; }
        public DateTime? Accountopeningdate { get; set; }
        public string Budgcode { get; set; }
        public string Budgname { get; set; }
        public string Opentofkcode { get; set; }
        public string Opentofkfullname { get; set; }
        public string Servicetofkcode { get; set; }
        public string Servicetofkfullname { get; set; }
        public string Createtofkcode { get; set; }
        public string Createtofkfullname { get; set; }
        public string OiFirstreqnum { get; set; }
        public string OiFirstreqguid { get; set; }
        public DateTime? OiFirstreqdate { get; set; }
        public string OiLastreqnum { get; set; }
        public string OiLastreqguid { get; set; }
        public DateTime? OiLastreqdate { get; set; }
        public string CiInn { get; set; }
        public string CiKpp { get; set; }
        public string CiOkpo { get; set; }
        public string Accountopeningreason { get; set; }
        public string Accountopeningnumber { get; set; }
        public string Accountopeningnamedoc { get; set; }
        public DateTime? Accountopenreasondate { get; set; }
        public DateTime? Accountreservdate { get; set; }
        public string Ordinalnumber { get; set; }
        public string Typecustom { get; set; }
        public string CbBankaccountnumber { get; set; }
        public string CbBankname { get; set; }
        public string CbBankbik { get; set; }
        public string CbBankcorraccount { get; set; }
        public string CbAssignaccountnum { get; set; }
        public string CbClosereason { get; set; }
        public string Syscode { get; set; }
        public string Codeshname { get; set; }
        public string Ksnumber { get; set; }

        public virtual ICollection<FsPaletterinfoList> FsPaletterinfoList { get; set; }
        public virtual ICollection<FsPasectionList> FsPasectionList { get; set; }
    }
}
