using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrLeaveSetting
{
    public int LvsIdpk { get; set; }

    public DateTime? LvsDate { get; set; }

    public string? LvsCriteria { get; set; }

    public int? LvsEmployeeGroupIdfk { get; set; }

    public int? LvsAbsenceTypeIdfk { get; set; }

    public decimal? LvsStartNumberOfMonths { get; set; }

    public decimal? LvsEndNumberOfMonths { get; set; }

    public int? LvsNumberOfDays { get; set; }

    public bool? LvsActive { get; set; }

    public string? LvsRmks { get; set; }

    public string? LvsCreatedBy { get; set; }

    public int? LvsEditedBy { get; set; }

    public DateTime? LvsCreationDate { get; set; }

    public DateTime? LvsEditedDate { get; set; }
}
