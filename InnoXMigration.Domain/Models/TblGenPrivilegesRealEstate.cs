using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenPrivilegesRealEstate
{
    public int PreIdpk { get; set; }

    public int? PreEmpIdfk { get; set; }

    public bool? PreSupervisor { get; set; }

    public bool? PreManager { get; set; }

    public bool? PreDirector { get; set; }

    public bool? PreCeo { get; set; }

    public bool? PreOfficer { get; set; }

    public bool? PreFacilitiesServiceSupervisor { get; set; }

    public bool? PrePreparesJobCards { get; set; }

    public bool? PreRecommendsJobCards { get; set; }

    public bool? PreAuthorisesJobCards { get; set; }

    public bool? PreApprovalSupervisor { get; set; }

    public bool? PreApprovalManager { get; set; }

    public bool? PreApprovalDirector { get; set; }

    public bool? PreApprovalCeo1 { get; set; }

    public bool? PreApprovalCeo2 { get; set; }

    public bool? PreOrgAdmin { get; set; }

    public bool? PreDeptAdmin { get; set; }

    public bool? PreSectionAdmin { get; set; }

    public bool? PreUnitAdmin { get; set; }

    public bool? PreAllowBacklogEntry { get; set; }

    public bool? PreFacilitiesAdmin { get; set; }

    public bool? PreFacilitiesServiceOfficer { get; set; }

    public string? PreRmks { get; set; }

    public int? PreCreatedBy { get; set; }

    public int? PreEditedBy { get; set; }

    public DateTime? PreCreationDate { get; set; }

    public DateTime? PreEditedDate { get; set; }
}
