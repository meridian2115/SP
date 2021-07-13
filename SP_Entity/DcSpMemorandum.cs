using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SP_Entity
{
    public partial class DcSpMemorandum
    {
        public DcSpMemorandum()
        {
            FsPropChangesInFbExpList = new HashSet<FsPropChangesInFbExpList>();
        }

        public decimal Docid { get; set; }
        public decimal? Version { get; set; }
        public string InfPlperiodYear { get; set; }
        public string InfPlperiodYear1 { get; set; }
        public string InfPlperiodYear2 { get; set; }
        public string InfDocnumber { get; set; }
        public DateTime? InfDocdate { get; set; }
        public DateTime? InfRegdate { get; set; }
        public string InfGrbsName { get; set; }
        public string InfGrbsMessage { get; set; }
        public string InfReasonForAmendment { get; set; }
        public string InfReasonsForChanges { get; set; }
        public string InfConclusionGp { get; set; }
        public string InfAccountPayableObl { get; set; }
        public string InfApprovalInformation { get; set; }
        public string InfDepartmentOpinion { get; set; }
        public string InfRequisites { get; set; }
        public string InfApps { get; set; }
        public string SystemFieldsKbk { get; set; }
        public string SystemFieldsSecrecy { get; set; }
        public string SystemFieldsGuid { get; set; }
        public string SystemFieldsDoctype { get; set; }
        public string AgreementSign { get; set; }
        public string AgreementFullName { get; set; }
        public DateTime? AgreementSignDate { get; set; }
        public string AgreementNotes { get; set; }
        public string SystemFieldsDocguid { get; set; }

        public virtual ICollection<FsPropChangesInFbExpList> FsPropChangesInFbExpList { get; set; }
    }
}
