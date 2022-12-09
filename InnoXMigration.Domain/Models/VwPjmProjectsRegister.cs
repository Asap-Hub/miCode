using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmProjectsRegister
{
    public int PjrIdpk { get; set; }

    public string PjrPhase { get; set; } = null!;

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public int? PjrProjectNameIdfk { get; set; }

    public int PnmIdpk { get; set; }

    public string PnmName { get; set; } = null!;

    public string PnmShtName { get; set; } = null!;

    public DateTime? PnmStartDate { get; set; }

    public DateTime? PnmActualEndDate { get; set; }

    public DateTime? PnmProposedEndDate { get; set; }

    public byte? PnmNoOfPhases { get; set; }

    public bool? PnmActive { get; set; }

    public string? PnmRmks { get; set; }

    public DateTime? PjrStartDate { get; set; }

    public DateTime? PjrProposedEndDate { get; set; }

    public DateTime? PjrActualEndDate { get; set; }

    public int? ProjectActualDuration { get; set; }

    public int? ProjectProposedDuration { get; set; }

    public int PjrcategoryIdfk { get; set; }

    public int PjrstatusIdfk { get; set; }

    public int PjrpriorityIdfk { get; set; }

    public bool Pjractive { get; set; }

    public string Pjrrmks { get; set; } = null!;

    public int? PrtIdpk { get; set; }

    public string? PrtName { get; set; }

    public string? PrtShtName { get; set; }

    public decimal? PrtOrder { get; set; }

    public bool? PrtActive { get; set; }

    public string? PrtRmks { get; set; }

    public int? PrcIdpk { get; set; }

    public string? PrcName { get; set; }

    public string? PrcShtName { get; set; }

    public bool? PrcActive { get; set; }

    public string? PrcRmks { get; set; }

    public int? StsIdpk { get; set; }

    public string? StsName { get; set; }

    public string? StsShtName { get; set; }

    public bool? StsActive { get; set; }

    public string? StsRmks { get; set; }

    public byte? StsOrder { get; set; }

    public decimal PjrPercentComplete { get; set; }

    public string PjrDescription { get; set; } = null!;

    public string PjrLastDoneBy { get; set; } = null!;

    public int PjrLastUpdatedBy { get; set; }

    public string PjrProjectLocations { get; set; } = null!;

    public string PjrRequestDepartment { get; set; } = null!;

    public string PjrEstimatedCost { get; set; } = null!;

    public string PjrCertifiedAmount { get; set; } = null!;

    public string PjrCompensationCost { get; set; } = null!;

    public string PjrContingencyCost { get; set; } = null!;

    public string PjrProductValueCost { get; set; } = null!;

    public string PjrAmountPaid { get; set; } = null!;

    public string PjrClaimsPaid { get; set; } = null!;

    public string PjrCompensationsPaid { get; set; } = null!;

    public string PjrContingenciesPaid { get; set; } = null!;

    public string PjrProductValuesPaid { get; set; } = null!;

    public DateTime? PjrLastUpdatedOn { get; set; }

    public string PjrOwner { get; set; } = null!;

    public string PjrUpdates { get; set; } = null!;

    public string PjrRevisions { get; set; } = null!;

    public string PjrBaseValue { get; set; } = null!;

    public string PjrContractValue { get; set; } = null!;

    public decimal PjrContingencyPercentage { get; set; }

    public bool PjrLocked { get; set; }

    public string PjrDurationUnit { get; set; } = null!;

    public string PjrProposedDuration { get; set; } = null!;

    public string PjrActualDuration { get; set; } = null!;

    public string PjrContractors { get; set; } = null!;

    public string PjrFundingSources { get; set; } = null!;

    public string PjrExpectedClaims { get; set; } = null!;

    public int PjrProposedDurationNumber { get; set; }

    public int PjrActualDurationNumber { get; set; }

    public string PjrOutstandingCertifiedAmount { get; set; } = null!;

    public int? DurationDeviation { get; set; }

    public string? DurationDeviationx { get; set; }

    public bool PjrCapitalProject { get; set; }
}
