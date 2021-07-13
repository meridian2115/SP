using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HArpreport0503kvrm
    {
        public HArpreport0503kvrm()
        {
            HfsT10List = new HashSet<HfsT10List>();
            HfsT11List = new HashSet<HfsT11List>();
            HfsT12List = new HashSet<HfsT12List>();
            HfsT13List = new HashSet<HfsT13List>();
            HfsT14List = new HashSet<HfsT14List>();
            HfsT15List = new HashSet<HfsT15List>();
            HfsT16List = new HashSet<HfsT16List>();
            HfsT4List = new HashSet<HfsT4List>();
            HfsT5List = new HashSet<HfsT5List>();
            HfsT6List = new HashSet<HfsT6List>();
            HfsT7List = new HashSet<HfsT7List>();
            HfsT8List = new HashSet<HfsT8List>();
            HfsT9List = new HashSet<HfsT9List>();
        }

        public decimal Id { get; set; }
        public string HrBudgLevel { get; set; }
        public string Surrogat { get; set; }
        public decimal? S6G17 { get; set; }
        public decimal? S10G17 { get; set; }
        public decimal? S11G17 { get; set; }
        public decimal? S14G17 { get; set; }
        public decimal? S4G17 { get; set; }
        public decimal? S5G17 { get; set; }
        public decimal? S7G17 { get; set; }
        public decimal? S8G17 { get; set; }
        public decimal? S9G17 { get; set; }
        public decimal? S12G17 { get; set; }
        public decimal? S13G17 { get; set; }
        public decimal? S15G17 { get; set; }
        public decimal? S16G17 { get; set; }

        public virtual ICollection<HfsT10List> HfsT10List { get; set; }
        public virtual ICollection<HfsT11List> HfsT11List { get; set; }
        public virtual ICollection<HfsT12List> HfsT12List { get; set; }
        public virtual ICollection<HfsT13List> HfsT13List { get; set; }
        public virtual ICollection<HfsT14List> HfsT14List { get; set; }
        public virtual ICollection<HfsT15List> HfsT15List { get; set; }
        public virtual ICollection<HfsT16List> HfsT16List { get; set; }
        public virtual ICollection<HfsT4List> HfsT4List { get; set; }
        public virtual ICollection<HfsT5List> HfsT5List { get; set; }
        public virtual ICollection<HfsT6List> HfsT6List { get; set; }
        public virtual ICollection<HfsT7List> HfsT7List { get; set; }
        public virtual ICollection<HfsT8List> HfsT8List { get; set; }
        public virtual ICollection<HfsT9List> HfsT9List { get; set; }
    }
}
