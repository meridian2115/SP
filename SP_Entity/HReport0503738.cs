using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class HReport0503738
    {
        public HReport0503738()
        {
            HfsOOR200List = new HashSet<HfsOOR200List>();
            HfsR2T510List = new HashSet<HfsR2T510List>();
        }

        public decimal Id { get; set; }
        public decimal? OC4R200 { get; set; }
        public decimal? OC5R200 { get; set; }
        public decimal? OC6R200 { get; set; }
        public decimal? OC7R200 { get; set; }
        public decimal? OC8R200 { get; set; }
        public decimal? OC9R200 { get; set; }
        public decimal? OC10R200 { get; set; }
        public decimal? OC11R200 { get; set; }
        public decimal? R2C4R510 { get; set; }
        public decimal? R2C5R510 { get; set; }
        public decimal? R2C6R510 { get; set; }
        public decimal? R2C7R510 { get; set; }
        public decimal? R2C8R510 { get; set; }
        public decimal? R2C9R510 { get; set; }
        public decimal? R2C10R510 { get; set; }
        public decimal? R2C11R510 { get; set; }
        public decimal? R3C4R900 { get; set; }
        public decimal? R3C5R900 { get; set; }
        public decimal? R3C6R900 { get; set; }
        public decimal? R3C7R900 { get; set; }
        public decimal? R3C8R900 { get; set; }
        public decimal? R3C9R900 { get; set; }
        public decimal? R3C10R900 { get; set; }
        public decimal? R3C11R900 { get; set; }
        public decimal? R3C4R910 { get; set; }
        public decimal? R3C5R910 { get; set; }
        public decimal? R3C6R910 { get; set; }
        public decimal? R3C7R910 { get; set; }
        public decimal? R3C8R910 { get; set; }
        public decimal? R3C9R910 { get; set; }
        public decimal? R3C10R910 { get; set; }
        public decimal? R3C11R910 { get; set; }
        public decimal? R3C4R911 { get; set; }
        public decimal? R3C5R911 { get; set; }
        public decimal? R3C6R911 { get; set; }
        public decimal? R3C7R911 { get; set; }
        public decimal? R3C8R911 { get; set; }
        public decimal? R3C9R911 { get; set; }
        public decimal? R3C10R911 { get; set; }
        public decimal? R3C11R911 { get; set; }
        public decimal? R3C4R920 { get; set; }
        public decimal? R3C5R920 { get; set; }
        public decimal? R3C6R920 { get; set; }
        public decimal? R3C7R920 { get; set; }
        public decimal? R3C8R920 { get; set; }
        public decimal? R3C9R920 { get; set; }
        public decimal? R3C10R920 { get; set; }
        public decimal? R3C11R920 { get; set; }
        public decimal? R3C4R921 { get; set; }
        public decimal? R3C5R921 { get; set; }
        public decimal? R3C6R921 { get; set; }
        public decimal? R3C7R921 { get; set; }
        public decimal? R3C8R921 { get; set; }
        public decimal? R3C9R921 { get; set; }
        public decimal? R3C10R921 { get; set; }
        public decimal? R3C11R921 { get; set; }
        public decimal? R3C4R999 { get; set; }
        public decimal? R3C5R999 { get; set; }
        public decimal? R3C6R999 { get; set; }
        public decimal? R3C7R999 { get; set; }
        public decimal? R3C8R999 { get; set; }
        public decimal? R3C9R999 { get; set; }
        public decimal? R3C10R999 { get; set; }
        public decimal? R3C11R999 { get; set; }
        public string Nameseparatedivision { get; set; }
        public string Codeseparatedivision { get; set; }
        public string Namefounder { get; set; }
        public string Codefounder { get; set; }
        public string Namebodyactingfounder { get; set; }
        public string Codebodyactingfounder { get; set; }

        public virtual ICollection<HfsOOR200List> HfsOOR200List { get; set; }
        public virtual ICollection<HfsR2T510List> HfsR2T510List { get; set; }
    }
}
