using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsTab005List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string TofkCd { get; set; }
        public string Cdchapter { get; set; }
        public string Nmchapter { get; set; }
        public string CdSr { get; set; }
        public string Fullname { get; set; }
        public string Cdtpsub { get; set; }
        public string Info { get; set; }
        public DateTime? Dateorder { get; set; }
        public DateTime? Datefact { get; set; }
        public string FormCd { get; set; }
        public string FormOkud { get; set; }
        public string FormAcc { get; set; }
        public string FormAi { get; set; }
        public string FormAiAll { get; set; }
        public string FormSys { get; set; }
        public string Errors { get; set; }
        public string Errortype { get; set; }
        public string Errorcodes { get; set; }
        public string Controltype { get; set; }
        public string Commenterror { get; set; }
        public string Klassanddicts { get; set; }
        public string Nmklassanddicts { get; set; }
        public string Indexcode { get; set; }
        public string Commentksdct { get; set; }
        public string Infopz { get; set; }
        public string Content { get; set; }
        public string Commentinfopz { get; set; }
        public string BoDo { get; set; }
        public decimal? SumBo { get; set; }
        public decimal? SumDo { get; set; }
        public string CommentboDo { get; set; }
        public string Note { get; set; }
        public string Guidflc { get; set; }
        public string Guididc { get; set; }
        public string Guidbdc { get; set; }
        public string GuidbdcSets { get; set; }
        public string GuidflcDict { get; set; }
        public string Subotch { get; set; }
        public string Tofk2 { get; set; }

        public virtual DcArpReport000005 Doc { get; set; }
    }
}
