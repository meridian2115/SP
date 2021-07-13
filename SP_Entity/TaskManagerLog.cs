using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class TaskManagerLog
    {
        public TaskManagerLog()
        {
            InverseNext = new HashSet<TaskManagerLog>();
            InverseParent = new HashSet<TaskManagerLog>();
        }

        public decimal Id { get; set; }
        public decimal? ParentId { get; set; }
        public string TriggerName { get; set; }
        public string State { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public DateTime? DateStarted { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? DateEnded { get; set; }
        public byte[] Result { get; set; }
        public string Payload { get; set; }
        public string FinalState { get; set; }
        public decimal? NextId { get; set; }
        public string DocUuids { get; set; }

        public virtual TaskManagerLog Next { get; set; }
        public virtual TaskManagerLog Parent { get; set; }
        public virtual ICollection<TaskManagerLog> InverseNext { get; set; }
        public virtual ICollection<TaskManagerLog> InverseParent { get; set; }
    }
}
