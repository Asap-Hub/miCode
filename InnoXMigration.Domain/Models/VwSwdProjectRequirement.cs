using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectRequirement
{
    public int PrqIdpk { get; set; }

    public DateTime? PrqDate { get; set; }

    public int? PrqProjectIdfk { get; set; }

    public int? PrqProposedByIdfk { get; set; }

    public string? PrqRequirement { get; set; }

    public bool? PrqActive { get; set; }

    public string? PrqRmks { get; set; }

    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public int PrbIdpk { get; set; }

    public string? PrbName { get; set; }

    public string? PrbShtName { get; set; }

    public int? PrqImpactIdfk { get; set; }

    public int PimIdpk { get; set; }

    public string? PimName { get; set; }

    public string? PimShtName { get; set; }

    public decimal PrqPercentComplete { get; set; }

    public string PrqUpdates { get; set; } = null!;

    public int PrqStatusIdfk { get; set; }

    public string PrqLastDoneBy { get; set; } = null!;

    public string PrqLastUpdatedBy { get; set; } = null!;

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public int? ApmProjectIdfk { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmRmks { get; set; }

    public int? PrqModuleIdfk { get; set; }

    public string PrqRequirementHeader { get; set; } = null!;
}
