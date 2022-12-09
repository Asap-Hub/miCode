using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectsRegister
{
    public int PjrIdpk { get; set; }

    public int? PjrProjectNameIdfk { get; set; }

    public string? PjrPhase { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public DateTime? PjrStartDate { get; set; }

    public DateTime? PjrActualEndDate { get; set; }

    public DateTime? PjrProposedEndDate { get; set; }

    public DateTime? PjrCommissioningDate { get; set; }

    public DateTime? PjrPtocDate { get; set; }

    public DateTime? PjrFtocDate { get; set; }

    public DateTime? PjrStartDld { get; set; }

    public DateTime? PjrEndDld { get; set; }

    public string? PjrDurationUnit { get; set; }

    public string? PjrProposedDuration { get; set; }

    public string? PjrActualDuration { get; set; }

    public int? PjrProposedDurationNumber { get; set; }

    public int? PjrActualDurationNumber { get; set; }

    public string? PjrRevisions { get; set; }

    public string? PjrProjectLocations { get; set; }

    public string? PjrRequestDepartment { get; set; }

    public string? PjrEstimatedCost { get; set; }

    public string? PjrCertifiedAmount { get; set; }

    public string? PjrOutstandingCertifiedAmount { get; set; }

    public string? PjrContingencyCost { get; set; }

    public string? PjrContingenciesPaid { get; set; }

    public decimal? PjrContingencyPercentage { get; set; }

    public string? PjrProductValueCost { get; set; }

    public string? PjrCompensationCost { get; set; }

    public string? PjrAmountPaid { get; set; }

    public string? PjrClaimsPaid { get; set; }

    public string? PjrProductValuesPaid { get; set; }

    public string? PjrCompensationsPaid { get; set; }

    public string? PjrBaseValue { get; set; }

    public string? PjrContractValue { get; set; }

    public DateTime? PjrLastUpdatedOn { get; set; }

    public int? PjrCategoryIdfk { get; set; }

    public int? PjrStatusIdfk { get; set; }

    public int? PjrPriorityIdfk { get; set; }

    public int? PjrImpactIdfk { get; set; }

    public string? PjrOwner { get; set; }

    public string? PjrDescription { get; set; }

    public string? PjrUpdates { get; set; }

    public decimal? PjrPercentComplete { get; set; }

    public string? PjrFundingSources { get; set; }

    public string? PjrExpectedClaims { get; set; }

    public string? PjrContractors { get; set; }

    public string? PjrLastDoneBy { get; set; }

    public int? PjrLastUpdatedBy { get; set; }

    public bool? PjrLocked { get; set; }

    public bool? PjrCapitalProject { get; set; }

    public bool? PjrActive { get; set; }

    public string? PjrRmks { get; set; }

    public int? PjrCreatedBy { get; set; }

    public int? PjrEditedBy { get; set; }

    public DateTime? PjrCreationDate { get; set; }

    public DateTime? PjrEditedDate { get; set; }
}
