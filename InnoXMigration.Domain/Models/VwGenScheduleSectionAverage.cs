using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleSectionAverage
{
    public int? SxnIdpk { get; set; }

    public string? SxnShtName { get; set; }

    public decimal? AveragPercentComplete { get; set; }

    public decimal? WeightedPercentComplete { get; set; }

    public string? StartMonthYear { get; set; }
}
