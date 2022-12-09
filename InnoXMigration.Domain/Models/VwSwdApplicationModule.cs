using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdApplicationModule
{
    public int ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public int ApmProjectIdfk { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmCode { get; set; }

    public byte? ApmOrder { get; set; }

    public bool? ApmIsHelpModule { get; set; }

    public byte? ApmHelpModuleOrder { get; set; }

    public bool ApmIsHelpModuleOnly { get; set; }

    public string? ApmRmks { get; set; }

    public int? ApmCreatedBy { get; set; }

    public int? ApmEditedBy { get; set; }

    public DateTime? ApmCreationDate { get; set; }

    public DateTime? ApmEditedDate { get; set; }

    public int PrjIdpk { get; set; }

    public string PrjName { get; set; } = null!;

    public string PrjShtName { get; set; } = null!;

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

    public string? PrjRmks { get; set; }

    public bool? PrjActive { get; set; }

    public string? PrjLastDoneBy { get; set; }

    public int? PrjLastUpdatedBy { get; set; }
}
