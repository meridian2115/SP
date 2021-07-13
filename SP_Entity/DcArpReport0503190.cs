using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503190
    {
        public DcArpReport0503190()
        {
            FsInfo100190List = new HashSet<FsInfo100190List>();
            FsInfo200190List = new HashSet<FsInfo200190List>();
            FsInfo300190List = new HashSet<FsInfo300190List>();
            FsInfo400190List = new HashSet<FsInfo400190List>();
            FsInfo410190List = new HashSet<FsInfo410190List>();
            FsInfo510190List = new HashSet<FsInfo510190List>();
            FsInfo520190List = new HashSet<FsInfo520190List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public DateTime? Date01012018 { get; set; }
        public decimal? S10016 { get; set; }
        public decimal? S10017 { get; set; }
        public decimal? S10018 { get; set; }
        public decimal? S10019 { get; set; }
        public decimal? S10020 { get; set; }
        public decimal? S10021 { get; set; }
        public decimal? S10022 { get; set; }
        public decimal? S20016 { get; set; }
        public decimal? S20017 { get; set; }
        public decimal? S20018 { get; set; }
        public decimal? S20019 { get; set; }
        public decimal? S20020 { get; set; }
        public decimal? S20021 { get; set; }
        public decimal? S20022 { get; set; }
        public decimal? S30016 { get; set; }
        public decimal? S30017 { get; set; }
        public decimal? S30018 { get; set; }
        public decimal? S30019 { get; set; }
        public decimal? S30020 { get; set; }
        public decimal? S30021 { get; set; }
        public decimal? S30022 { get; set; }
        public decimal? S40016 { get; set; }
        public decimal? S40017 { get; set; }
        public decimal? S40018 { get; set; }
        public decimal? S40019 { get; set; }
        public decimal? S40020 { get; set; }
        public decimal? S40021 { get; set; }
        public decimal? S40022 { get; set; }
        public decimal? S41016 { get; set; }
        public decimal? S41017 { get; set; }
        public decimal? S41018 { get; set; }
        public decimal? S41019 { get; set; }
        public decimal? S41020 { get; set; }
        public decimal? S41021 { get; set; }
        public decimal? S41022 { get; set; }
        public decimal? S50016 { get; set; }
        public decimal? S50017 { get; set; }
        public decimal? S50018 { get; set; }
        public decimal? S50019 { get; set; }
        public decimal? S50020 { get; set; }
        public decimal? S50021 { get; set; }
        public decimal? S50022 { get; set; }
        public decimal? S51016 { get; set; }
        public decimal? S51017 { get; set; }
        public decimal? S51018 { get; set; }
        public decimal? S51019 { get; set; }
        public decimal? S51020 { get; set; }
        public decimal? S51021 { get; set; }
        public decimal? S51022 { get; set; }
        public decimal? S52016 { get; set; }
        public decimal? S52017 { get; set; }
        public decimal? S52018 { get; set; }
        public decimal? S52019 { get; set; }
        public decimal? S52020 { get; set; }
        public decimal? S52021 { get; set; }
        public decimal? S52022 { get; set; }
        public decimal? S60016 { get; set; }
        public decimal? S60017 { get; set; }
        public decimal? S60018 { get; set; }
        public decimal? S60019 { get; set; }
        public decimal? S60020 { get; set; }
        public decimal? S60021 { get; set; }
        public decimal? S60022 { get; set; }

        public virtual ICollection<FsInfo100190List> FsInfo100190List { get; set; }
        public virtual ICollection<FsInfo200190List> FsInfo200190List { get; set; }
        public virtual ICollection<FsInfo300190List> FsInfo300190List { get; set; }
        public virtual ICollection<FsInfo400190List> FsInfo400190List { get; set; }
        public virtual ICollection<FsInfo410190List> FsInfo410190List { get; set; }
        public virtual ICollection<FsInfo510190List> FsInfo510190List { get; set; }
        public virtual ICollection<FsInfo520190List> FsInfo520190List { get; set; }
    }
}
