using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmRequirement
{
    public int PrqIdpk { get; set; }

    public DateTime? PrqDate { get; set; }

    public int? PrqProjectIdfk { get; set; }

    public int? PrqProposedByIdfk { get; set; }

    public int? PrqImpactIdfk { get; set; }

    public string? PrqRequirement { get; set; }

    public decimal? PrqPercentComplete { get; set; }

    public string? PrqUpdates { get; set; }

    public int? PrqStatusIdfk { get; set; }

    public int? PrqModuleIdfk { get; set; }

    public string? PrqLastDoneBy { get; set; }

    public string? PrqLastUpdatedBy { get; set; }

    public bool? PrqActive { get; set; }

    public string? PrqRmks { get; set; }

    public int? PrqCreatedBy { get; set; }

    public int? PrqEditedBy { get; set; }

    public DateTime? PrqCreationDate { get; set; }

    public DateTime? PrqEditedDate { get; set; }
}
