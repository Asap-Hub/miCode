using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSftSafetyTopic
{
    public int StpIdpk { get; set; }

    public string? StpTitle { get; set; }

    public string? StpDescription { get; set; }

    public string? StpSource { get; set; }

    public int? StpSafetyGroupIdfk { get; set; }

    public bool? StpRejected { get; set; }

    public bool? StpRecommended { get; set; }

    public bool? StpApproved { get; set; }

    public bool? StpEdit { get; set; }

    public int? StpRecommendedByEmpIdfk { get; set; }

    public int? StpApprovedByEmpIdfk { get; set; }

    public int? StpRejectedByEmpIdfk { get; set; }

    public DateTime? StpApprovedOn { get; set; }

    public DateTime? StpRecommendedOn { get; set; }

    public DateTime? StpRejectedOn { get; set; }

    public bool? StpActive { get; set; }

    public string? StpRmks { get; set; }

    public int? StpCreatedBy { get; set; }

    public int? StpEditedBy { get; set; }

    public DateTime? StpCreationDate { get; set; }

    public DateTime? StpEditedDate { get; set; }
}
