using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcReport0503117
    {
        public DcReport0503117()
        {
            FsBeR2200List = new HashSet<FsBeR2200List>();
            FsBrR1010List = new HashSet<FsBrR1010List>();
            FsFbR4200List = new HashSet<FsFbR4200List>();
            FsFeR7010List = new HashSet<FsFeR7010List>();
            FsFeR7200List = new HashSet<FsFeR7200List>();
            FsFeR7520List = new HashSet<FsFeR7520List>();
            FsFeR7620List = new HashSet<FsFeR7620List>();
            FsFkR5200List = new HashSet<FsFkR5200List>();
            FsFoR8100List = new HashSet<FsFoR8100List>();
            FsFoR8200List = new HashSet<FsFoR8200List>();
            FsFoR8300List = new HashSet<FsFoR8300List>();
            FsFoR8400List = new HashSet<FsFoR8400List>();
            FsFoR8500List = new HashSet<FsFoR8500List>();
            FsFoR8600List = new HashSet<FsFoR8600List>();
            FsFoR8700List = new HashSet<FsFoR8700List>();
            FsFoR8800List = new HashSet<FsFoR8800List>();
            FsFrR6010List = new HashSet<FsFrR6010List>();
            FsFrR6200List = new HashSet<FsFrR6200List>();
            FsFrR6520List = new HashSet<FsFrR6520List>();
            FsFrR6620List = new HashSet<FsFrR6620List>();
            FsFrR6710List = new HashSet<FsFrR6710List>();
            FsFrR6720List = new HashSet<FsFrR6720List>();
            FsSfR3520List = new HashSet<FsSfR3520List>();
            FsSfR3620List = new HashSet<FsSfR3620List>();
            FsSfR3710List = new HashSet<FsSfR3710List>();
            FsSfR3720List = new HashSet<FsSfR3720List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Ord { get; set; }
        public string BrC2R010 { get; set; }
        public decimal? BrC4R010 { get; set; }
        public decimal? BrC5R010 { get; set; }
        public decimal? BrC6R010 { get; set; }
        public decimal? BrC7R010 { get; set; }
        public decimal? BeC4R200 { get; set; }
        public decimal? BeC5R200 { get; set; }
        public decimal? BeC6R200 { get; set; }
        public decimal? BeC7R200 { get; set; }
        public decimal? BeC4R450 { get; set; }
        public decimal? BeC5R450 { get; set; }
        public decimal? BeC6R450 { get; set; }
        public decimal? BeC7R450 { get; set; }
        public decimal? SfC4R500 { get; set; }
        public decimal? SfC5R500 { get; set; }
        public decimal? SfC6R500 { get; set; }
        public decimal? SfC7R500 { get; set; }
        public decimal? SfC4R520 { get; set; }
        public decimal? SfC5R520 { get; set; }
        public decimal? SfC6R520 { get; set; }
        public decimal? SfC7R520 { get; set; }
        public decimal? SfC4R620 { get; set; }
        public decimal? SfC5R620 { get; set; }
        public decimal? SfC6R620 { get; set; }
        public decimal? SfC7R620 { get; set; }
        public string SfC3bR700 { get; set; }
        public decimal? SfC4R700 { get; set; }
        public decimal? SfC5R700 { get; set; }
        public decimal? SfC6R700 { get; set; }
        public decimal? SfC7R700 { get; set; }
        public decimal? SfC4R710 { get; set; }
        public decimal? SfC5R710 { get; set; }
        public decimal? SfC6R710 { get; set; }
        public decimal? SfC7R710 { get; set; }
        public decimal? SfC4R720 { get; set; }
        public decimal? SfC5R720 { get; set; }
        public decimal? SfC6R720 { get; set; }
        public decimal? SfC7R720 { get; set; }
        public string SfC3bR7002 { get; set; }
        public decimal? SfC4R7002 { get; set; }
        public decimal? SfC5R7002 { get; set; }
        public decimal? SfC6R7002 { get; set; }
        public decimal? SfC7R7002 { get; set; }
        public string SfC3bR7003 { get; set; }
        public decimal? SfC4R7003 { get; set; }
        public decimal? SfC5R7003 { get; set; }
        public decimal? SfC6R7003 { get; set; }
        public decimal? SfC7R7003 { get; set; }
        public string SfC2R720 { get; set; }
        public string SfC2R710 { get; set; }
        public string SfC2R620 { get; set; }
        public string SfC2R520 { get; set; }
        public string SfC3bR710 { get; set; }
        public string SfC3bR720 { get; set; }
        public string Surrogat { get; set; }
        public string Namtip { get; set; }
        public DateTime? Dataarp7238 { get; set; }
        public string SePfnLeader { get; set; }
        public string SePfnChiefAcc { get; set; }
        public string SePfnLeaderOfFes { get; set; }
        public string SePfnPostLeader { get; set; }
        public string SePfnPostChiefAcc { get; set; }
        public string SePfnPostLeaderOf { get; set; }
        public string SePfnExecutor { get; set; }
        public string SePfnPostExecutor { get; set; }
        public string SePfnPhone { get; set; }
        public decimal? FbC4R200 { get; set; }
        public decimal? FbC5R200 { get; set; }
        public decimal? FbC6R200 { get; set; }
        public decimal? FkC4R200 { get; set; }
        public decimal? FkC5R200 { get; set; }
        public decimal? FkC6R200 { get; set; }
        public decimal? FrC4R010 { get; set; }
        public decimal? FrC4R200 { get; set; }
        public decimal? FrC4R500 { get; set; }
        public decimal? FrC4R520 { get; set; }
        public decimal? FrC4R620 { get; set; }
        public decimal? FrC4R700 { get; set; }
        public decimal? FrC4R710 { get; set; }
        public decimal? FrC4R720 { get; set; }
        public decimal? FeC4R010 { get; set; }
        public decimal? FeC5R010 { get; set; }
        public decimal? FeC4R200 { get; set; }
        public decimal? FeC5R200 { get; set; }
        public decimal? FeC4R500 { get; set; }
        public decimal? FeC5R500 { get; set; }
        public decimal? FeC4R520 { get; set; }
        public decimal? FeC5R520 { get; set; }
        public decimal? FeC4R620 { get; set; }
        public decimal? FeC5R620 { get; set; }
        public decimal? FeC4R700 { get; set; }
        public decimal? FeC5R700 { get; set; }
        public decimal? FoC4R100 { get; set; }
        public decimal? FoC5R100 { get; set; }
        public decimal? FoC4R200 { get; set; }
        public decimal? FoC5R200 { get; set; }
        public decimal? FoC4R300 { get; set; }
        public decimal? FoC5R300 { get; set; }
        public decimal? FoC4R400 { get; set; }
        public decimal? FoC5R400 { get; set; }
        public decimal? FoC4R500 { get; set; }
        public decimal? FoC5R500 { get; set; }
        public decimal? FoC4R600 { get; set; }
        public decimal? FoC5R600 { get; set; }
        public decimal? FoC4R700 { get; set; }
        public decimal? FoC5R700 { get; set; }
        public decimal? FoC4R800 { get; set; }
        public decimal? FoC5R800 { get; set; }
        public string Guid117 { get; set; }
        public string Telephone { get; set; }
        public string Guidier { get; set; }
        public decimal? Year { get; set; }
        public decimal? Yeararp7238 { get; set; }
        public decimal? Year2017 { get; set; }

        public virtual ICollection<FsBeR2200List> FsBeR2200List { get; set; }
        public virtual ICollection<FsBrR1010List> FsBrR1010List { get; set; }
        public virtual ICollection<FsFbR4200List> FsFbR4200List { get; set; }
        public virtual ICollection<FsFeR7010List> FsFeR7010List { get; set; }
        public virtual ICollection<FsFeR7200List> FsFeR7200List { get; set; }
        public virtual ICollection<FsFeR7520List> FsFeR7520List { get; set; }
        public virtual ICollection<FsFeR7620List> FsFeR7620List { get; set; }
        public virtual ICollection<FsFkR5200List> FsFkR5200List { get; set; }
        public virtual ICollection<FsFoR8100List> FsFoR8100List { get; set; }
        public virtual ICollection<FsFoR8200List> FsFoR8200List { get; set; }
        public virtual ICollection<FsFoR8300List> FsFoR8300List { get; set; }
        public virtual ICollection<FsFoR8400List> FsFoR8400List { get; set; }
        public virtual ICollection<FsFoR8500List> FsFoR8500List { get; set; }
        public virtual ICollection<FsFoR8600List> FsFoR8600List { get; set; }
        public virtual ICollection<FsFoR8700List> FsFoR8700List { get; set; }
        public virtual ICollection<FsFoR8800List> FsFoR8800List { get; set; }
        public virtual ICollection<FsFrR6010List> FsFrR6010List { get; set; }
        public virtual ICollection<FsFrR6200List> FsFrR6200List { get; set; }
        public virtual ICollection<FsFrR6520List> FsFrR6520List { get; set; }
        public virtual ICollection<FsFrR6620List> FsFrR6620List { get; set; }
        public virtual ICollection<FsFrR6710List> FsFrR6710List { get; set; }
        public virtual ICollection<FsFrR6720List> FsFrR6720List { get; set; }
        public virtual ICollection<FsSfR3520List> FsSfR3520List { get; set; }
        public virtual ICollection<FsSfR3620List> FsSfR3620List { get; set; }
        public virtual ICollection<FsSfR3710List> FsSfR3710List { get; set; }
        public virtual ICollection<FsSfR3720List> FsSfR3720List { get; set; }
    }
}
