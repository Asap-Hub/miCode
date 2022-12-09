using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectModulesxx
{
    public int ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public int? ApmProjectIdfk { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmRmks { get; set; }

    public int? PrjIdpk { get; set; }

    public string? PrjName { get; set; }

    public string? PrjShtName { get; set; }

    public DateTime? PrjStartDate { get; set; }

    public DateTime? PrjProposedEndDate { get; set; }

    public DateTime? PrjActualEndDate { get; set; }

    public DateTime? PrjLastUpdatedOn { get; set; }

    public int? PrjCategoryIdfk { get; set; }

    public int PrjStatusIdfk { get; set; }

    public int PrjPriorityIdfk { get; set; }

    public int PrjImpactIdfk { get; set; }

    public int? PrjDeptIdfk { get; set; }

    public int? PrjSectionIdfk { get; set; }

    public string? PrjRequestedBy { get; set; }

    public string PrjDescription { get; set; } = null!;

    public string PrjUpdates { get; set; } = null!;

    public decimal PrjPercentComplete { get; set; }

    public string PrjLastDoneBy { get; set; } = null!;

    public int? PrjLastUpdatedBy { get; set; }

    public bool PrjActive { get; set; }

    public string PrjRmks { get; set; } = null!;

    public byte FmdlOrder { get; set; }

    public bool FmdlIsHelpModule { get; set; }

    public byte FmdlHelpModuleOrder { get; set; }

    public string FmdlCode { get; set; } = null!;
}
