using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleDeptAverage
{
    public int? ScpDeptIdfk { get; set; }

    public string? DptShtName { get; set; }

    public decimal? AveragPercentComplete { get; set; }

    public decimal? AverageWeightedPercentComplete { get; set; }

    public string? StartMonthYear { get; set; }
}
