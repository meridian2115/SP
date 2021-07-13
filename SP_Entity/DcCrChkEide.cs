using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcCrChkEide
    {
        public DcCrChkEide()
        {
            FsCeidedocList = new HashSet<FsCeidedocList>();
            FsCeideleftList = new HashSet<FsCeideleftList>();
            FsCeideparamList = new HashSet<FsCeideparamList>();
            FsCeiderightList = new HashSet<FsCeiderightList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string Expression { get; set; }
        public string Formula { get; set; }
        public string Formulaname { get; set; }
        public string Formula1 { get; set; }
        public string Formulaname1 { get; set; }
        public string Filtercurr { get; set; }
        public string Crutch { get; set; }
        public string P1Nmbr { get; set; }
        public string P1Codecr { get; set; }
        public string P1Addcr { get; set; }
        public string P1Codereportform { get; set; }
        public string P1AiCode { get; set; }
        public string P1AiName { get; set; }
        public bool? P1PrDaily { get; set; }
        public bool? P1PrKvart { get; set; }
        public bool? P1PrMount { get; set; }
        public bool? P1PrHalfy { get; set; }
        public bool? P1PrYear { get; set; }
        public DateTime? P1PrProizv { get; set; }
        public bool? P1PrNadatu { get; set; }
        public string P1PrTemp1 { get; set; }
        public string P1PrTemp2 { get; set; }
        public string P1PrTemp3 { get; set; }
        public string P1PrTemp4 { get; set; }
        public string P1PrTemp5 { get; set; }
        public string P1PrTemp6 { get; set; }
        public string P1PrPeriod { get; set; }
        public string P1Type { get; set; }
        public string P1Checktype { get; set; }
        public string P1Errortext { get; set; }

        public virtual ICollection<FsCeidedocList> FsCeidedocList { get; set; }
        public virtual ICollection<FsCeideleftList> FsCeideleftList { get; set; }
        public virtual ICollection<FsCeideparamList> FsCeideparamList { get; set; }
        public virtual ICollection<FsCeiderightList> FsCeiderightList { get; set; }
    }
}
