using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueLog
{
    public int IlgIdpk { get; set; }

    public DateTime? IlgIssueDate { get; set; }

    public DateTime? IlgDueDate { get; set; }

    public int? IlgReportedByEmpIdfk { get; set; }

    public int? IlgDeptIdfk { get; set; }

    public int? IlgSectionIdfk { get; set; }

    public int? IlgCategoryIdfk { get; set; }

    public int? IlgIssueTypeIdfk { get; set; }

    public int? IlgClassIdfk { get; set; }

    public int? IlgSubclassIdfk { get; set; }

    public int? IlgStatusIdfk { get; set; }

    public int? IlgImpactIdfk { get; set; }

    public int? IlgLocationIdfk { get; set; }

    public int? IlgPriorityIdfk { get; set; }

    public int? IlgFormIdfk { get; set; }

    public byte? IlgInitialPercentComplete { get; set; }

    public byte? IlgPercentComplete { get; set; }

    public string? IlgIssue { get; set; }

    public string? IlgTechnicalDescription { get; set; }

    public byte[]? IlgImage { get; set; }

    public string? IlgResolutionActivity { get; set; }

    public string? IlgAcceptanceRmks { get; set; }

    public bool? IlgFixed { get; set; }

    public bool? IlgClosed { get; set; }

    public decimal? IlgRating { get; set; }

    public int? IlgImpact { get; set; }

    public string? IlgUpdatedBy { get; set; }

    public string? IlgUpdatedByDept { get; set; }

    public string? IlgUpdatedBySection { get; set; }

    public string? IlgUpdatedByLocation { get; set; }

    public int? IlgCreatedBy { get; set; }

    public int? IlgEditedBy { get; set; }

    public int? IlgFixedBy { get; set; }

    public bool? IlgActive { get; set; }

    public DateTime? IlgCreationDate { get; set; }

    public DateTime? IlgEditedDate { get; set; }

    public DateTime? IlgCompletionDate { get; set; }

    public DateTime? IlgUpdateDate { get; set; }
}
