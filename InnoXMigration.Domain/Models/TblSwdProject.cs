using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProject
{
    public int PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public DateTime? PrjProposedEndDate { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public DateTime? PrjLastUpdatedOn { get; set; }

    public int? PrjCategoryIdfk { get; set; }

    public int? PrjStatusIdfk { get; set; }

    public int? PrjPriorityIdfk { get; set; }

    public int? PrjImpactIdfk { get; set; }

    public int? PrjDeptIdfk { get; set; }

    public int? PrjSectionIdfk { get; set; }

    public string? PrjRequestedBy { get; set; }

    public string? PrjDescription { get; set; }

    public string? PrjUpdates { get; set; }

    public decimal? PrjPercentComplete { get; set; }

    public string? PrjLastDoneBy { get; set; }

    public int? PrjLastUpdatedBy { get; set; }

    public bool? PrjActive { get; set; }

    public string? PrjRmks { get; set; }

    public int? PrjCreatedBy { get; set; }

    public int? PrjEditedBy { get; set; }

    public DateTime? PrjCreationDate { get; set; }

    public DateTime? PrjEditedDate { get; set; }
}
