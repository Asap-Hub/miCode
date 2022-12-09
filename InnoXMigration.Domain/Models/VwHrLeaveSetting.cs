using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrLeaveSetting
{
    public int LvsIdpk { get; set; }

    public DateTime? LvsDate { get; set; }

    public string? LvsCriteria { get; set; }

    public int? LvsEmployeeGroupIdfk { get; set; }

    public decimal? LvsStartNumberOfMonths { get; set; }

    public decimal? LvsEndNumberOfMonths { get; set; }

    public int? LvsNumberOfDays { get; set; }

    public bool? LvsActive { get; set; }

    public string? LvsRmks { get; set; }

    public int EgpIdpk { get; set; }

    public string? EgpName { get; set; }

    public string? EgpShtName { get; set; }

    public bool? EgpActive { get; set; }

    public int? LvsAbsenceTypeIdfk { get; set; }

    public int AtpIdpk { get; set; }

    public string? AtpName { get; set; }

    public string? AtpShtName { get; set; }

    public bool? AtpActive { get; set; }

    public bool? AtpAnnualLeave { get; set; }
}
