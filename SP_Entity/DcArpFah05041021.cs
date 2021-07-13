using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcArpFah05041021
    {
        public DcArpFah05041021()
        {
            FsDo0504102List = new HashSet<FsDo0504102List>();
            FsT0504102List = new HashSet<FsT0504102List>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string FullName { get; set; }
        public string NmbrDoc { get; set; }
        public DateTime? Data { get; set; }
        public string CodeInst { get; set; }
        public string NameInst { get; set; }
        public string OkpoInst { get; set; }
        public string CodeSpO { get; set; }
        public string NameSpO { get; set; }
        public string CodeMolO { get; set; }
        public string NameMolO { get; set; }
        public string CodeSpP { get; set; }
        public string NameSpP { get; set; }
        public string CodeMolP { get; set; }
        public string NameMolP { get; set; }
        public string TypeDoc { get; set; }
        public string NumerDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string CodeOper { get; set; }
        public string TypeOper { get; set; }
        public DateTime? DateUchet { get; set; }
        public string Kppv { get; set; }

        public virtual ICollection<FsDo0504102List> FsDo0504102List { get; set; }
        public virtual ICollection<FsT0504102List> FsT0504102List { get; set; }
    }
}
