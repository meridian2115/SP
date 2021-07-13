using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcRefUbpandnubp
    {
        public DcRefUbpandnubp()
        {
            FsUbpauthpubcustList = new HashSet<FsUbpauthpubcustList>();
            FsUbpauthsList = new HashSet<FsUbpauthsList>();
            FsUbpauthsorgbudgList = new HashSet<FsUbpauthsorgbudgList>();
            FsUbpauthspubobList = new HashSet<FsUbpauthspubobList>();
            FsUbpbankaccountsList = new HashSet<FsUbpbankaccountsList>();
            FsUbpfkaccountsList = new HashSet<FsUbpfkaccountsList>();
            FsUbpfoaccountsList = new HashSet<FsUbpfoaccountsList>();
            FsUbpinfocontractList = new HashSet<FsUbpinfocontractList>();
            FsUbpinfoksopenList = new HashSet<FsUbpinfoksopenList>();
            FsUbpnubpauthsList = new HashSet<FsUbpnubpauthsList>();
            FsUbpokvedcodesList = new HashSet<FsUbpokvedcodesList>();
            FsUbporganauthsList = new HashSet<FsUbporganauthsList>();
            FsUbppauthsList = new HashSet<FsUbppauthsList>();
            FsUbpprevrecnumList = new HashSet<FsUbpprevrecnumList>();
            FsUbpsignheadsList = new HashSet<FsUbpsignheadsList>();
            FsUbpspzauthsList = new HashSet<FsUbpspzauthsList>();
            FsUbpsuccessionsList = new HashSet<FsUbpsuccessionsList>();
            FsUbptransfauthbpList = new HashSet<FsUbptransfauthbpList>();
            FsUbptransfauthbuList = new HashSet<FsUbptransfauthbuList>();
            FsUbptransfauthfoList = new HashSet<FsUbptransfauthfoList>();
            FsUbpuchrorgansList = new HashSet<FsUbpuchrorgansList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Guid { get; set; }
        public DateTime? Startdateactive { get; set; }
        public DateTime? Enddateactive { get; set; }
        public string Status { get; set; }
        public string Recordnum { get; set; }
        public string Controlnum { get; set; }
        public string Registrycode { get; set; }
        public string Selforfkcode { get; set; }
        public string Orgcode { get; set; }
        public string Mainorgcode { get; set; }
        public string Mainorgname { get; set; }
        public string Orgogrn { get; set; }
        public string Orgfullname { get; set; }
        public string Orgshortname { get; set; }
        public string Orgfirmname { get; set; }
        public string Orgaltname { get; set; }
        public string Orginn { get; set; }
        public string Orgkpp { get; set; }
        public DateTime? Fnsregdate { get; set; }
        public string Okopfname { get; set; }
        public string Okfsname { get; set; }
        public string AdPostindex { get; set; }
        public string AdRegionkladrcodeCode { get; set; }
        public string AdRegioncodeCode { get; set; }
        public string AdRegiontypeCode { get; set; }
        public string AdRegionname { get; set; }
        public string AdPlanningstructuretype { get; set; }
        public string AdPlanningstructurename { get; set; }
        public string AdAreacodeCode { get; set; }
        public string AdAreatypeCode { get; set; }
        public string AdAreaname { get; set; }
        public string AdCitycodeCode { get; set; }
        public string AdCitytypeCode { get; set; }
        public string AdCityname { get; set; }
        public string AdLocalcodeCode { get; set; }
        public string AdLocaltypeCode { get; set; }
        public string AdLocalname { get; set; }
        public string AdStreetcodeCode { get; set; }
        public string AdStreettypeCode { get; set; }
        public string AdStreetname { get; set; }
        public string AdHouse { get; set; }
        public string AdBuilding { get; set; }
        public string AdApartment { get; set; }
        public string AdOktmoname { get; set; }
        public string AdOrfkname { get; set; }
        public string AdOksmcodeCode { get; set; }
        public string AdOksmname { get; set; }
        public string AdForeignaddress { get; set; }
        public string OpOgvppotypename { get; set; }
        public string OpOgvppocode { get; set; }
        public string OpOgvpponame { get; set; }
        public string OpUchrppotypename { get; set; }
        public string OpUchrppocode { get; set; }
        public string OpUchrpponame { get; set; }
        public string OpIsuchr { get; set; }
        public string PoRbsname { get; set; }
        public string PoKbkglavaname { get; set; }
        public string PoRbscode { get; set; }
        public string CdOkoguname { get; set; }
        public string CdOkpocode { get; set; }
        public string BuOrgbudglevelname { get; set; }
        public string BuOrgbudgname { get; set; }
        public string BuKbkglavaorgname { get; set; }
        public string FiFormwaycode { get; set; }
        public string FiFormwayname { get; set; }
        public string RiReorgdocname { get; set; }
        public string RiReorgdocnum { get; set; }
        public DateTime? RiReorgdocdate { get; set; }
        public string RiReorgwaycode { get; set; }
        public string RiReorgwayname { get; set; }
        public DateTime? RiReorgstartdate { get; set; }
        public DateTime? RiReorgenddate { get; set; }
        public string AcAccmanagement { get; set; }
        public string ToOrgtypename { get; set; }
        public string ToUchrezhtypename { get; set; }
        public string UoUoname { get; set; }
        public string UoFoorougvfname { get; set; }
        public string CtOrgphone { get; set; }
        public string CtOrgsite { get; set; }
        public string CtOrgemail { get; set; }
        public string CtInfdocname { get; set; }
        public string CtInfdocnum { get; set; }
        public DateTime? CtInfdocdate { get; set; }
        public bool? InIsogv { get; set; }
        public bool? InIsobosob { get; set; }
        public bool? InIsexcl { get; set; }
        public bool? InIsreorg { get; set; }
        public bool? InIsul { get; set; }
        public string CcPubpcode { get; set; }
        public string CcRubpcode { get; set; }
        public string CcNubpcode { get; set; }
        public string CcSpzcode { get; set; }
        public string CcPgmucode { get; set; }
        public string OkOkatoname { get; set; }
        public string RqFirstreqnum { get; set; }
        public string RqFirstreqguid { get; set; }
        public DateTime? RqFirstreqdate { get; set; }
        public string RqLastreqnum { get; set; }
        public string RqLastreqguid { get; set; }
        public DateTime? RqLastreqdate { get; set; }
        public string RqUpdatereason { get; set; }
        public decimal? RqUpdatenum { get; set; }
        public DateTime? RqDatestartinfo { get; set; }
        public string SdContourtypecode { get; set; }
        public DateTime? SdEgrulupdatedate { get; set; }
        public DateTime? SdEgruldataupdate { get; set; }
        public DateTime? SdDateinclusion { get; set; }
        public DateTime? SdDateexclusion { get; set; }
        public string SdOrgstatus { get; set; }
        public DateTime? SdTimestampdstr { get; set; }
        public string Institutionid { get; set; }
        public string Uocheck { get; set; }
        public bool? Publishepbs { get; set; }
        public bool? Publishosgmu { get; set; }
        public string Sepdivorgname { get; set; }
        public string Sepdivorg { get; set; }
        public bool? Orgnotegrul { get; set; }
        public bool? Iszu { get; set; }
        public string Recordnumold { get; set; }
        public string Speceventcode { get; set; }
        public string Speceventcodedop1 { get; set; }
        public string Speceventcodedop2 { get; set; }
        public string Speceventcodedop3 { get; set; }
        public bool? Nointer { get; set; }
        public string Errorinfotext { get; set; }
        public bool? Checkpim { get; set; }
        public string Flagrequedelete { get; set; }
        public string Foauthcount { get; set; }
        public DateTime? Datequitepbs { get; set; }
        public string Violationquitepbs { get; set; }
        public DateTime? Datequitosgmu { get; set; }
        public string Violationquitosgmu { get; set; }
        public string Uocreate { get; set; }
        public string Okopfcode { get; set; }
        public string Okfscode { get; set; }
        public string AdOktmocode { get; set; }
        public string AdOrfkcode { get; set; }
        public string OpOgvppotypecode { get; set; }
        public string OpUchrppotypecode { get; set; }
        public string PoKbkglavacode { get; set; }
        public string CdOkogucode { get; set; }
        public string BuOrgbudglevelcode { get; set; }
        public string BuOrgbudgcode { get; set; }
        public string BuKbkglavaorg { get; set; }
        public string ToOrgtypecode { get; set; }
        public string ToUchrezhtypecode { get; set; }
        public string UoUocode { get; set; }
        public string UoFoorougvfcode { get; set; }
        public string OkOkatocode { get; set; }
        public bool? Headegrulnot { get; set; }
        public bool? Dsp { get; set; }

        public virtual ICollection<FsUbpauthpubcustList> FsUbpauthpubcustList { get; set; }
        public virtual ICollection<FsUbpauthsList> FsUbpauthsList { get; set; }
        public virtual ICollection<FsUbpauthsorgbudgList> FsUbpauthsorgbudgList { get; set; }
        public virtual ICollection<FsUbpauthspubobList> FsUbpauthspubobList { get; set; }
        public virtual ICollection<FsUbpbankaccountsList> FsUbpbankaccountsList { get; set; }
        public virtual ICollection<FsUbpfkaccountsList> FsUbpfkaccountsList { get; set; }
        public virtual ICollection<FsUbpfoaccountsList> FsUbpfoaccountsList { get; set; }
        public virtual ICollection<FsUbpinfocontractList> FsUbpinfocontractList { get; set; }
        public virtual ICollection<FsUbpinfoksopenList> FsUbpinfoksopenList { get; set; }
        public virtual ICollection<FsUbpnubpauthsList> FsUbpnubpauthsList { get; set; }
        public virtual ICollection<FsUbpokvedcodesList> FsUbpokvedcodesList { get; set; }
        public virtual ICollection<FsUbporganauthsList> FsUbporganauthsList { get; set; }
        public virtual ICollection<FsUbppauthsList> FsUbppauthsList { get; set; }
        public virtual ICollection<FsUbpprevrecnumList> FsUbpprevrecnumList { get; set; }
        public virtual ICollection<FsUbpsignheadsList> FsUbpsignheadsList { get; set; }
        public virtual ICollection<FsUbpspzauthsList> FsUbpspzauthsList { get; set; }
        public virtual ICollection<FsUbpsuccessionsList> FsUbpsuccessionsList { get; set; }
        public virtual ICollection<FsUbptransfauthbpList> FsUbptransfauthbpList { get; set; }
        public virtual ICollection<FsUbptransfauthbuList> FsUbptransfauthbuList { get; set; }
        public virtual ICollection<FsUbptransfauthfoList> FsUbptransfauthfoList { get; set; }
        public virtual ICollection<FsUbpuchrorgansList> FsUbpuchrorgansList { get; set; }
    }
}
