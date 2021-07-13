using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class FsLaExecutor723List
    {
        public decimal? Docid { get; set; }
        public decimal? Tablerownum { get; set; }
        public decimal Fieldsetid { get; set; }
        public string ExecutorOrder { get; set; }
        public string ExecutorDsc { get; set; }
        public string ExecutorNote { get; set; }
        public DateTime? ExecutorStartdate { get; set; }
        public DateTime? ExecutorDate { get; set; }
        public string ExecutorState { get; set; }
        public string ExecutorUsername { get; set; }
        public string ExecutorSfp { get; set; }
        public string ExecutorPost { get; set; }
        public string ExecutorDepartment { get; set; }
        public bool? Electronicsign { get; set; }

        public virtual DcMscExpendableschedule Doc { get; set; }
    }
}
