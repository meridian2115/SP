using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503790N
    {
        public DcArpReport0503790N()
        {
            FsS1T100790List = new HashSet<FsS1T100790List>();
            FsS2T200790List = new HashSet<FsS2T200790List>();
            FsS3T300790List = new HashSet<FsS3T300790List>();
            FsS4T400790List = new HashSet<FsS4T400790List>();
            FsS5T410790List = new HashSet<FsS5T410790List>();
            FsS7T510790List = new HashSet<FsS7T510790List>();
            FsS8T520790List = new HashSet<FsS8T520790List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? S1C10016 { get; set; }
        public decimal? S1C10017 { get; set; }
        public decimal? S1C10018 { get; set; }
        public decimal? S1C10019 { get; set; }
        public decimal? S1C10020 { get; set; }
        public decimal? S1C10021 { get; set; }
        public decimal? S1C10022 { get; set; }
        public decimal? S2C20016 { get; set; }
        public decimal? S2C20017 { get; set; }
        public decimal? S2C20018 { get; set; }
        public decimal? S2C20019 { get; set; }
        public decimal? S2C20020 { get; set; }
        public decimal? S2C20021 { get; set; }
        public decimal? S2C20022 { get; set; }
        public decimal? S3C30016 { get; set; }
        public decimal? S3C30017 { get; set; }
        public decimal? S3C30018 { get; set; }
        public decimal? S3C30019 { get; set; }
        public decimal? S3C30020 { get; set; }
        public decimal? S3C30021 { get; set; }
        public decimal? S3C30022 { get; set; }
        public decimal? S4C40016 { get; set; }
        public decimal? S4C40017 { get; set; }
        public decimal? S4C40018 { get; set; }
        public decimal? S4C40019 { get; set; }
        public decimal? S4C40020 { get; set; }
        public decimal? S4C40021 { get; set; }
        public decimal? S4C40022 { get; set; }
        public decimal? S5C41016 { get; set; }
        public decimal? S5C41017 { get; set; }
        public decimal? S5C41018 { get; set; }
        public decimal? S5C41019 { get; set; }
        public decimal? S5C41020 { get; set; }
        public decimal? S5C41021 { get; set; }
        public decimal? S5C41022 { get; set; }
        public decimal? S6C50016 { get; set; }
        public decimal? S6C50017 { get; set; }
        public decimal? S6C50018 { get; set; }
        public decimal? S6C50019 { get; set; }
        public decimal? S6C50020 { get; set; }
        public decimal? S6C50021 { get; set; }
        public decimal? S6C50022 { get; set; }
        public decimal? S7C51016 { get; set; }
        public decimal? S7C51017 { get; set; }
        public decimal? S7C51018 { get; set; }
        public decimal? S7C51019 { get; set; }
        public decimal? S7C51020 { get; set; }
        public decimal? S7C51021 { get; set; }
        public decimal? S7C51022 { get; set; }
        public decimal? S8C52016 { get; set; }
        public decimal? S8C52017 { get; set; }
        public decimal? S8C52018 { get; set; }
        public decimal? S8C52019 { get; set; }
        public decimal? S8C52020 { get; set; }
        public decimal? S8C52021 { get; set; }
        public decimal? S8C52022 { get; set; }
        public decimal? S9C60016 { get; set; }
        public decimal? S9C60017 { get; set; }
        public decimal? S9C60018 { get; set; }
        public decimal? S9C60019 { get; set; }
        public decimal? S9C60020 { get; set; }
        public decimal? S9C60021 { get; set; }
        public decimal? S9C60022 { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public string SeCaCode { get; set; }
        public string SeCaName { get; set; }
        public string SeCaOgrn { get; set; }
        public string SeCaInn { get; set; }
        public string SeCaKpp { get; set; }
        public string SeCaCaLeader { get; set; }
        public string SeCaCaExecutor { get; set; }
        public string SeCaPostCaLeader { get; set; }
        public string SeCaPostCaExecutor { get; set; }
        public string SeCaCaExecutorMail { get; set; }
        public string SeAddress { get; set; }
        public string Ord { get; set; }
        public string Surrogat { get; set; }

        public virtual ICollection<FsS1T100790List> FsS1T100790List { get; set; }
        public virtual ICollection<FsS2T200790List> FsS2T200790List { get; set; }
        public virtual ICollection<FsS3T300790List> FsS3T300790List { get; set; }
        public virtual ICollection<FsS4T400790List> FsS4T400790List { get; set; }
        public virtual ICollection<FsS5T410790List> FsS5T410790List { get; set; }
        public virtual ICollection<FsS7T510790List> FsS7T510790List { get; set; }
        public virtual ICollection<FsS8T520790List> FsS8T520790List { get; set; }
    }
}
