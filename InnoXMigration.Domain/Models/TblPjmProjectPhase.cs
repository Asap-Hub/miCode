using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectPhase
{
    public int PhsIdpk { get; set; }

    public int? PhsProjectIdfk { get; set; }

    public string? PhsName { get; set; }

    public string? PhsShtName { get; set; }

    public DateTime? PhsStartDate { get; set; }

    public DateTime? PhsActualEndDate { get; set; }

    public DateTime? PhsProposedEndDate { get; set; }

    public DateTime? PhsCommissioningDate { get; set; }

    public DateTime? PhsPtocDate { get; set; }

    public DateTime? PhsFtocDate { get; set; }

    public DateTime? PhsStartDld { get; set; }

    public DateTime? PhsEndDld { get; set; }

    public string? PhsDurationUnit { get; set; }

    public string? PhsProposedDuration { get; set; }

    public string? PhsActualDuration { get; set; }

    public int? PhsProposedDurationNumber { get; set; }

    public int? PhsActualDurationNumber { get; set; }

    public string? PhsRevisions { get; set; }

    public string? PhsProjectLocations { get; set; }

    public string? PhsRequestDepartment { get; set; }

    public string? PhsEstimatedCost { get; set; }

    public string? PhsCertifiedAmount { get; set; }

    public string? PhsOutstandingCertifiedAmount { get; set; }

    public string? PhsContingencyCost { get; set; }

    public string? PhsContingenciesPaid { get; set; }

    public decimal? PhsContingencyPercentage { get; set; }

    public string? PhsProductValueCost { get; set; }

    public string? PhsCompensationCost { get; set; }

    public string? PhsAmountPaid { get; set; }

    public string? PhsClaimsPaid { get; set; }

    public string? PhsProductValuesPaid { get; set; }

    public string? PhsCompensationsPaid { get; set; }

    public string? PhsBaseValue { get; set; }

    public string? PhsContractValue { get; set; }

    public DateTime? PhsLastUpdatedOn { get; set; }

    public int? PhsCategoryIdfk { get; set; }

    public int? PhsStatusIdfk { get; set; }

    public int? PhsPriorityIdfk { get; set; }

    public int? PhsImpactIdfk { get; set; }

    public string? PhsOwner { get; set; }

    public string? PhsDescription { get; set; }

    public string? PhsUpdates { get; set; }

    public decimal? PhsPercentComplete { get; set; }

    public string? PhsFundingSources { get; set; }

    public string? PhsExpectedClaims { get; set; }

    public string? PhsContractors { get; set; }

    public string? PhsLastDoneBy { get; set; }

    public int? PhsLastUpdatedBy { get; set; }

    public bool? PhsLocked { get; set; }

    public bool? PhsActive { get; set; }

    public string? PhsRmks { get; set; }

    public int? PhsCreatedBy { get; set; }

    public int? PhsEditedBy { get; set; }

    public DateTime? PhsCreationDate { get; set; }

    public DateTime? PhsEditedDate { get; set; }
}
