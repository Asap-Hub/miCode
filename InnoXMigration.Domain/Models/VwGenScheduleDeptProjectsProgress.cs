using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenScheduleDeptProjectsProgress
{
    public string? ScpName { get; set; }

    public int? TaskCount { get; set; }

    public DateTime? ScpStartDate { get; set; }

    public DateTime? ScpEndDate { get; set; }

    public decimal? ScpPercentComplete { get; set; }

    public decimal? ScpReferencePercentComplete { get; set; }

    public DateTime? ScpLastUpdatedOn { get; set; }
}
