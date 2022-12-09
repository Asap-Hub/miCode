using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenPrivilegesTransportManagement
{
    public int PtmIdpk { get; set; }

    public int? PtmEmpIdfk { get; set; }

    public bool? PtmSysAdmin { get; set; }

    public bool? PtmWorkshopServiceOfficer { get; set; }

    public bool? PtmWorkshopServiceSupervisor { get; set; }

    public bool? PtmPreparesJobCards { get; set; }

    public bool? PtmRecommendsJobCards { get; set; }

    public bool? PtmAuthorisesJobCards { get; set; }

    public bool? PtmApprovalSupervisor { get; set; }

    public bool? PtmApprovalManager { get; set; }

    public bool? PtmApprovalDirector { get; set; }

    public bool? PtmApprovalCeo1 { get; set; }

    public bool? PtmApprovalCeo2 { get; set; }

    public bool? PtmSupervisor { get; set; }

    public bool? PtmManager { get; set; }

    public bool? PtmDirector { get; set; }

    public bool? PtmSaveConditionReturns { get; set; }

    public bool? PtmSubmitConditionReturns { get; set; }

    public bool? PtmFuelAnalyst { get; set; }

    public bool? PtmOrgAdmin { get; set; }

    public bool? PtmDeptAdmin { get; set; }

    public bool? PtmSectionAdmin { get; set; }

    public bool? PtmUnitAdmin { get; set; }

    public bool? PtmSaveDeptConditionReturns { get; set; }

    public bool? PtmSaveSectionConditionReturns { get; set; }

    public bool? PtmSubmitDeptConditionReturns { get; set; }

    public bool? PtmSubmitSectionConditionReturns { get; set; }

    public bool? PtmSeeDriversCodes { get; set; }

    public bool? PtmApproveFuelRequests { get; set; }

    public bool? PtmRecommendAllVehicleRequests { get; set; }

    public string? PtmRmks { get; set; }

    public int? PtmCreatedBy { get; set; }

    public int? PtmEditedBy { get; set; }

    public DateTime? PtmCreationDate { get; set; }

    public DateTime? PtmEditedDate { get; set; }
}
