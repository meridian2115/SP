using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503737Fk
    {
        public DcArpReport0503737Fk()
        {
            FsDTab737R1List = new HashSet<FsDTab737R1List>();
            FsIR3620List = new HashSet<FsIR3620List>();
            FsITab737R3List = new HashSet<FsITab737R3List>();
            FsRTab737R2List = new HashSet<FsRTab737R2List>();
            FsSR4950List = new HashSet<FsSR4950List>();
            FsSTab737R4List = new HashSet<FsSTab737R4List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }
        public string Surrogat { get; set; }
        public string NameKvfo { get; set; }
        public string CodeKvfo { get; set; }
        public string GlavaBkName { get; set; }
        public string CdRfName { get; set; }
        public decimal? TabR737C4R1901 { get; set; }
        public decimal? TabR737C5R1901 { get; set; }
        public decimal? TabR737C6R1901 { get; set; }
        public decimal? TabR737C7R1901 { get; set; }
        public decimal? TabR737C8R1901 { get; set; }
        public decimal? TabR737C9R1901 { get; set; }
        public decimal? TabR737C10R1901 { get; set; }
        public decimal? TabR737C4R1911 { get; set; }
        public decimal? TabR737C5R1911 { get; set; }
        public decimal? TabR737C6R1911 { get; set; }
        public decimal? TabR737C7R1911 { get; set; }
        public decimal? TabR737C8R1911 { get; set; }
        public decimal? TabR737C9R1911 { get; set; }
        public decimal? TabR737C10R1911 { get; set; }
        public decimal? TabR737C4R4501 { get; set; }
        public decimal? TabR737C5R4501 { get; set; }
        public decimal? TabR737C6R4501 { get; set; }
        public decimal? TabR737C7R4501 { get; set; }
        public decimal? TabR737C8R4501 { get; set; }
        public decimal? TabR737C9R4501 { get; set; }
        public string CntrlzdacctgCode { get; set; }
        public string CntrlzdacctgName { get; set; }
        public string CntrlzdacctgOgrn { get; set; }
        public string CntrlzdacctgInn { get; set; }
        public string CntrlzdacctgKpp { get; set; }
        public string CntrlzdacctgCaLeader { get; set; }
        public string CntrlzdacctgCaExecutor { get; set; }
        public string CntrlzdacctgCaExecutorMail { get; set; }
        public string CntrlzdacctgCaLeader1 { get; set; }
        public string CntrlzdacctgCaExecutor1 { get; set; }
        public bool? SubDiv { get; set; }
        public string Ord { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string Centbuch { get; set; }
        public string ParentSubject { get; set; }

        public virtual ICollection<FsDTab737R1List> FsDTab737R1List { get; set; }
        public virtual ICollection<FsIR3620List> FsIR3620List { get; set; }
        public virtual ICollection<FsITab737R3List> FsITab737R3List { get; set; }
        public virtual ICollection<FsRTab737R2List> FsRTab737R2List { get; set; }
        public virtual ICollection<FsSR4950List> FsSR4950List { get; set; }
        public virtual ICollection<FsSTab737R4List> FsSTab737R4List { get; set; }
    }
}
