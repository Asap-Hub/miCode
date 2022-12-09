using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtWorkProgram
{
    public int WkpIdpk { get; set; }

    public int? WkpBudgetIdfk { get; set; }

    public int? WkpDeptIdfk { get; set; }

    public int? WkpSectionIdfk { get; set; }

    public int? WkpActivityHeaderIdfk { get; set; }

    public int? WkpActivityUnitIdfk { get; set; }

    public int? WkpAnnualTargetIdfk { get; set; }

    public string? WkpResponsibilities { get; set; }

    public string? WkpQuarter1Target { get; set; }

    public string? WkpQuarter1Achieved { get; set; }

    public string? WkpQuarter2Target { get; set; }

    public string? WkpQuarter2Achieved { get; set; }

    public string? WkpQuarter3Target { get; set; }

    public string? WkpQuarter3Achieved { get; set; }

    public string? WkpQuarter4Target { get; set; }

    public string? WkpQuarter4Achieved { get; set; }

    public string? WkpActivityHeader { get; set; }

    public string? WkpActivity { get; set; }

    public int? WkpMeasureIdfk { get; set; }

    public string? WkpAdditionalResources { get; set; }

    public decimal? WkpPercentageComplete { get; set; }

    public string? WkpStatus { get; set; }

    public DateTime? WkpCompletionDate { get; set; }

    public DateTime? WkpLastUpdatedOn { get; set; }

    public bool? WkpActive { get; set; }

    public string? WkpRmks { get; set; }

    public int? WkpCreatedBy { get; set; }

    public int? WkpEditedBy { get; set; }

    public DateTime? WkpCreationDate { get; set; }

    public DateTime? WkpEditedDate { get; set; }
}
