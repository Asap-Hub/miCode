using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtWorkProgramUpdate
{
    public int WpuIdpk { get; set; }

    public DateTime? WpuDate { get; set; }

    public int? WpuBudgetIdfk { get; set; }

    public int? WpuWorkProgramIdfk { get; set; }

    public string? WpuUpdate { get; set; }

    public decimal? WpuPercentComplete { get; set; }

    public DateTime? WpuCompletionDate { get; set; }

    public string? WpuDoneBy { get; set; }

    public int? WpuStatusIdfk { get; set; }

    public bool? WpuActive { get; set; }

    public string? WpuRmks { get; set; }

    public string? WpuCreatedBy { get; set; }

    public int? WpuEditedBy { get; set; }

    public DateTime? WpuCreationDate { get; set; }

    public DateTime? WpuEditedDate { get; set; }
}
