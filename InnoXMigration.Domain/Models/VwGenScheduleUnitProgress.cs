using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleUnitProgress
{
    public decimal? AveragPercentComplete { get; set; }

    public decimal? WeightedPercentComplete { get; set; }

    public string? StartMonthYear { get; set; }
}
