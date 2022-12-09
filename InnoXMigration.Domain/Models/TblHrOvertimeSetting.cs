using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrOvertimeSetting
{
    public int OstIdpk { get; set; }

    public int? OstEmpIdfk { get; set; }

    public int? OstDeptIdfk { get; set; }

    public int? OstSectionIdfk { get; set; }

    public string? OstApprovalRoot { get; set; }

    public decimal? OstSupervisorHours { get; set; }

    public decimal? OstManagerHours { get; set; }

    public decimal? OstDirectorHours { get; set; }

    public decimal? OstCeHours { get; set; }

    public DateTime? OstStartDate { get; set; }

    public DateTime? OstEndDate { get; set; }

    public decimal? OstMinimumHours { get; set; }

    public decimal? OstMaximumHours { get; set; }

    public string? OstPer { get; set; }

    public bool? OstAllowUserToChangeOrg { get; set; }

    public bool? OstAllowSubmissionsOlderThanLastMonths { get; set; }

    public bool? OstAllowSubmissionsWithoutAppeal { get; set; }

    public bool? OstReviewToAuthorise { get; set; }

    public bool? OstEndorseToAuthorise { get; set; }

    public bool? OstApproveToAuthorise { get; set; }

    public bool? OstActive { get; set; }

    public string? OstRmks { get; set; }

    public string? OstCreatedBy { get; set; }

    public int? OstEditedBy { get; set; }

    public DateTime? OstCreationDate { get; set; }

    public DateTime? OstEditedDate { get; set; }
}
