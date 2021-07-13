using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MnModuleItem
    {
        public MnModuleItem()
        {
            InverseParent = new HashSet<MnModuleItem>();
        }

        public int ModuleItemId { get; set; }
        public int? ModuleCatalogId { get; set; }
        public int? ParentId { get; set; }
        public string ModuleItemName { get; set; }
        public string ShortModuleItemName { get; set; }
        public string UrlModuleItem { get; set; }
        public bool? EnabledFlag { get; set; }
        public DateTime? StartDateActive { get; set; }
        public DateTime? EndDateActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public short? OrderNum { get; set; }
        public string Icon { get; set; }
        public string ActionId { get; set; }

        public virtual MnModuleCatalog ModuleCatalog { get; set; }
        public virtual MnModuleItem Parent { get; set; }
        public virtual ICollection<MnModuleItem> InverseParent { get; set; }
    }
}
