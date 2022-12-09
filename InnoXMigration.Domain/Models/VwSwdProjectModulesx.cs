using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSwdProjectModulesx
{
    public int PmdIdpk { get; set; }

    public string? PmdName { get; set; }

    public string? PmdShtName { get; set; }

    public int? PmdProjectIdfk { get; set; }

    public bool? PmdActive { get; set; }

    public string? PmdRmks { get; set; }

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

    public decimal PmdOrder { get; set; }

    public bool PmdIsHelpModule { get; set; }

    public decimal PmdHelpModuleOrder { get; set; }

    public string PmdCode { get; set; } = null!;
}
