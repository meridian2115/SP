using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsFinSubTab1List
    {
        public FsFinSubTab1List()
        {
            FsFinSubTab402List = new HashSet<FsFinSubTab402List>();
            FsFinSubTab502List = new HashSet<FsFinSubTab502List>();
        }

        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string TempR300 { get; set; }
        public string C1R300 { get; set; }
        public string C1aR300 { get; set; }
        public string C1aaR300 { get; set; }
        public string C1bR300 { get; set; }
        public string C1cR300 { get; set; }
        public string C1dR300 { get; set; }
        public string C2R300 { get; set; }
        public string C3R300 { get; set; }
        public DateTime? C4R300 { get; set; }
        public string C5R300 { get; set; }
        public string C6R300 { get; set; }
        public string C7R300 { get; set; }
        public string C8R300 { get; set; }
        public string C9R300 { get; set; }
        public decimal? C10R300 { get; set; }
        public decimal? C11R300 { get; set; }
        public decimal? C12R300 { get; set; }
        public decimal? C13R300 { get; set; }
        public decimal? C14R300 { get; set; }
        public decimal? C15R300 { get; set; }
        public decimal? C16R300 { get; set; }
        public decimal? C17R300 { get; set; }
        public decimal? C18R300 { get; set; }
        public decimal? C19R300 { get; set; }
        public string C20R300 { get; set; }
        public decimal? C21R300 { get; set; }
        public decimal? C22R300 { get; set; }
        public DateTime? C23R300 { get; set; }
        public string C24R300 { get; set; }
        public decimal? C25R300 { get; set; }
        public decimal? C26R300 { get; set; }
        public DateTime? C27R300 { get; set; }
        public string C28R300 { get; set; }
        public string C2R400 { get; set; }
        public string C3R400 { get; set; }
        public DateTime? C4R400 { get; set; }
        public string C5R400 { get; set; }
        public string C6R400 { get; set; }
        public string C7R400 { get; set; }
        public string C8R400 { get; set; }
        public string C9R400 { get; set; }
        public decimal? C10R400 { get; set; }
        public decimal? C11R400 { get; set; }
        public decimal? C12R400 { get; set; }
        public decimal? C13R400 { get; set; }
        public decimal? C14R400 { get; set; }
        public decimal? C15R400 { get; set; }
        public decimal? C16R400 { get; set; }
        public decimal? C17R400 { get; set; }
        public decimal? C18R400 { get; set; }
        public decimal? C19R400 { get; set; }
        public string C20R400 { get; set; }
        public decimal? C21R400 { get; set; }
        public decimal? C22R400 { get; set; }
        public DateTime? C23R400 { get; set; }
        public string C24R400 { get; set; }
        public decimal? C25R400 { get; set; }
        public decimal? C26R400 { get; set; }
        public DateTime? C27R400 { get; set; }
        public string C28R400 { get; set; }
        public string C2R401 { get; set; }
        public string C3R401 { get; set; }
        public DateTime? C4R401 { get; set; }
        public string C5R401 { get; set; }
        public string C6R401 { get; set; }
        public string C7R401 { get; set; }
        public string C8R401 { get; set; }
        public string C9R401 { get; set; }
        public decimal? C14R401 { get; set; }
        public decimal? C15R401 { get; set; }
        public decimal? C17R401 { get; set; }
        public string C28R401 { get; set; }
        public decimal? C14R402 { get; set; }
        public decimal? C15R402 { get; set; }
        public decimal? C17R402 { get; set; }
        public string C2R500 { get; set; }
        public string C3R500 { get; set; }
        public DateTime? C4R500 { get; set; }
        public string C5R500 { get; set; }
        public string C6R500 { get; set; }
        public string C7R500 { get; set; }
        public string C8R500 { get; set; }
        public string C9R500 { get; set; }
        public decimal? C10R500 { get; set; }
        public decimal? C11R500 { get; set; }
        public decimal? C12R500 { get; set; }
        public decimal? C13R500 { get; set; }
        public decimal? C14R500 { get; set; }
        public decimal? C15R500 { get; set; }
        public decimal? C16R500 { get; set; }
        public decimal? C17R500 { get; set; }
        public decimal? C18R500 { get; set; }
        public decimal? C19R500 { get; set; }
        public string C20R500 { get; set; }
        public decimal? C21R500 { get; set; }
        public decimal? C22R500 { get; set; }
        public DateTime? C23R500 { get; set; }
        public string C24R500 { get; set; }
        public decimal? C25R500 { get; set; }
        public decimal? C26R500 { get; set; }
        public DateTime? C27R500 { get; set; }
        public string C28R500 { get; set; }
        public string C2R501 { get; set; }
        public string C3R501 { get; set; }
        public DateTime? C4R501 { get; set; }
        public string C5R501 { get; set; }
        public string C6R501 { get; set; }
        public string C7R501 { get; set; }
        public string C8R501 { get; set; }
        public string C9R501 { get; set; }
        public decimal? C14R501 { get; set; }
        public decimal? C15R501 { get; set; }
        public decimal? C17R501 { get; set; }
        public string C28R501 { get; set; }
        public decimal? C14R502 { get; set; }
        public decimal? C15R502 { get; set; }
        public decimal? C17R502 { get; set; }

        public virtual DcArpReportFinSub Doc { get; set; }
        public virtual ICollection<FsFinSubTab402List> FsFinSubTab402List { get; set; }
        public virtual ICollection<FsFinSubTab502List> FsFinSubTab502List { get; set; }
    }
}
