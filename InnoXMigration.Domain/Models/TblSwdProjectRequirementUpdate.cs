using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectRequirementUpdate
{
    public int PruIdpk { get; set; }

    public DateTime? PruDate { get; set; }

    public int? PruRequirementIdfk { get; set; }

    public string? PruUpdate { get; set; }

    public decimal? PruPercentComplete { get; set; }

    public DateTime? PruCompletionDate { get; set; }

    public int? PruStatusIdfk { get; set; }

    public int? PruImpactIdfk { get; set; }

    public string? PruDoneBy { get; set; }

    public string? PruDoneByDept { get; set; }

    public string PruDoneBySection { get; set; } = null!;

    public string? PruDoneByLocation { get; set; }

    public bool? PruActive { get; set; }

    public string? PruRmks { get; set; }

    public string? PruCreatedBy { get; set; }

    public int? PruEditedBy { get; set; }

    public DateTime? PruCreationDate { get; set; }

    public DateTime? PruEditedDate { get; set; }
}
