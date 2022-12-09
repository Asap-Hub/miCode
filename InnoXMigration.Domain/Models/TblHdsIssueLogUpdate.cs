using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHdsIssueLogUpdate
{
    public int IluIdpk { get; set; }

    public DateTime? IluDate { get; set; }

    public int? IluIssueLogIdfk { get; set; }

    public string? IluUpdate { get; set; }

    public decimal? IluPercentComplete { get; set; }

    public DateTime? IluCompletionDate { get; set; }

    public int? IluStatusIdfk { get; set; }

    public int? IluImpactIdfk { get; set; }

    public string? IluUpdatedBy { get; set; }

    public string? IluUpdatedByDept { get; set; }

    public string? IluUpdateBySection { get; set; }

    public string? IluUpdatedByLocation { get; set; }

    public bool? IluActive { get; set; }

    public string? IluRmks { get; set; }

    public string? IluCreatedBy { get; set; }

    public int? IluEditedBy { get; set; }

    public DateTime? IluCreationDate { get; set; }

    public DateTime? IluEditedDate { get; set; }
}
