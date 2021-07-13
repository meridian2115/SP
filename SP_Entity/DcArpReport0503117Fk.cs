using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpReport0503117Fk
    {
        public DcArpReport0503117Fk()
        {
            FsR10503117FkList = new HashSet<FsR10503117FkList>();
            FsR20503117FkList = new HashSet<FsR20503117FkList>();
            FsR30503117Fk520List = new HashSet<FsR30503117Fk520List>();
            FsR30503117Fk620List = new HashSet<FsR30503117Fk620List>();
            FsR30503117Fk710List = new HashSet<FsR30503117Fk710List>();
            FsR30503117Fk710aList = new HashSet<FsR30503117Fk710aList>();
            FsR30503117Fk720List = new HashSet<FsR30503117Fk720List>();
            FsR30503117Fk720aList = new HashSet<FsR30503117Fk720aList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public decimal? R010C4Sum { get; set; }
        public decimal? R010C5Sum { get; set; }
        public decimal? R010C6Sum { get; set; }
        public decimal? R010C7Sum { get; set; }
        public decimal? R200C4Sum { get; set; }
        public decimal? R200C5Sum { get; set; }
        public decimal? R200C6Sum { get; set; }
        public decimal? R200C7Sum { get; set; }
        public decimal? R200C8Sum { get; set; }
        public decimal? R200C9Sum { get; set; }
        public decimal? R450C4Sum { get; set; }
        public decimal? R450C5Sum { get; set; }
        public decimal? R450C6Sum { get; set; }
        public decimal? R450C7Sum { get; set; }
        public decimal? R450C8Sum { get; set; }
        public decimal? R450C9Sum { get; set; }
        public decimal? R500C4Sum { get; set; }
        public decimal? R500C5Sum { get; set; }
        public decimal? R500C6Sum { get; set; }
        public decimal? R500C7Sum { get; set; }
        public decimal? R500C8Sum { get; set; }
        public decimal? R500C9Sum { get; set; }
        public decimal? R520C4Sum { get; set; }
        public decimal? R520C5Sum { get; set; }
        public decimal? R520C6Sum { get; set; }
        public decimal? R520C7Sum { get; set; }
        public decimal? R520C8Sum { get; set; }
        public decimal? R520C9Sum { get; set; }
        public decimal? R620C4Sum { get; set; }
        public decimal? R620C5Sum { get; set; }
        public decimal? R620C6Sum { get; set; }
        public decimal? R620C7Sum { get; set; }
        public decimal? R620C8Sum { get; set; }
        public decimal? R620C9Sum { get; set; }
        public decimal? R700C4Sum { get; set; }
        public decimal? R700C5Sum { get; set; }
        public decimal? R700C6Sum { get; set; }
        public decimal? R700C7Sum { get; set; }
        public decimal? R700C8Sum { get; set; }
        public decimal? R700C9Sum { get; set; }
        public decimal? A700C4Sum { get; set; }
        public decimal? A700C5Sum { get; set; }
        public decimal? A700C6Sum { get; set; }
        public decimal? A700C7Sum { get; set; }
        public decimal? A700C8Sum { get; set; }
        public decimal? A700C9Sum { get; set; }
        public decimal? B700C4Sum { get; set; }
        public decimal? B700C5Sum { get; set; }
        public decimal? B700C6Sum { get; set; }
        public decimal? B700C7Sum { get; set; }
        public decimal? B700C8Sum { get; set; }
        public decimal? B700C9Sum { get; set; }
        public decimal? R710C4Sum { get; set; }
        public decimal? R710C5Sum { get; set; }
        public decimal? R710C6Sum { get; set; }
        public decimal? R710C7Sum { get; set; }
        public decimal? R710C8Sum { get; set; }
        public decimal? R710C9Sum { get; set; }
        public decimal? A710C4Sum { get; set; }
        public decimal? A710C5Sum { get; set; }
        public decimal? A710C6Sum { get; set; }
        public decimal? A710C7Sum { get; set; }
        public decimal? A710C8Sum { get; set; }
        public decimal? A710C9Sum { get; set; }
        public decimal? R720C4Sum { get; set; }
        public decimal? R720C5Sum { get; set; }
        public decimal? R720C6Sum { get; set; }
        public decimal? R720C7Sum { get; set; }
        public decimal? R720C8Sum { get; set; }
        public decimal? R720C9Sum { get; set; }
        public decimal? A720C4Sum { get; set; }
        public decimal? A720C5Sum { get; set; }
        public decimal? A720C6Sum { get; set; }
        public decimal? A720C7Sum { get; set; }
        public decimal? A720C8Sum { get; set; }
        public decimal? A720C9Sum { get; set; }
        public string PrintPt { get; set; }

        public virtual ICollection<FsR10503117FkList> FsR10503117FkList { get; set; }
        public virtual ICollection<FsR20503117FkList> FsR20503117FkList { get; set; }
        public virtual ICollection<FsR30503117Fk520List> FsR30503117Fk520List { get; set; }
        public virtual ICollection<FsR30503117Fk620List> FsR30503117Fk620List { get; set; }
        public virtual ICollection<FsR30503117Fk710List> FsR30503117Fk710List { get; set; }
        public virtual ICollection<FsR30503117Fk710aList> FsR30503117Fk710aList { get; set; }
        public virtual ICollection<FsR30503117Fk720List> FsR30503117Fk720List { get; set; }
        public virtual ICollection<FsR30503117Fk720aList> FsR30503117Fk720aList { get; set; }
    }
}
