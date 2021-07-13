using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class MnModuleCatalog
    {
        public MnModuleCatalog()
        {
            InverseParent = new HashSet<MnModuleCatalog>();
            MnModuleItem = new HashSet<MnModuleItem>();
        }

        public int ModuleCatalogId { get; set; }
        public string CatalogName { get; set; }
        public string ShortCatalogName { get; set; }
        public int? ParentId { get; set; }
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

        public virtual MnModuleCatalog Parent { get; set; }
        public virtual ICollection<MnModuleCatalog> InverseParent { get; set; }
        public virtual ICollection<MnModuleItem> MnModuleItem { get; set; }
    }
}
