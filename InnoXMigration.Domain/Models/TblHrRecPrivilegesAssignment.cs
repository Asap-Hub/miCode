using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrRecPrivilegesAssignment
{
    public int RpaIdpk { get; set; }

    public int? RpaEmpIdfk { get; set; }

    public int? RpaDeptIdfk { get; set; }

    public int? RpaSectionIdfk { get; set; }

    public bool? RpaCreateJobOpening { get; set; }

    public bool? RpaReviewJobOpenings { get; set; }

    public bool? RpaReviewApplications { get; set; }

    public bool? RpaScheduleInterviews { get; set; }

    public bool? RpaCaptureInterviewMarks { get; set; }

    public bool? RpaSendAlerts { get; set; }

    public bool? RpaViewAllRequests { get; set; }

    public bool? RpaSubmitForDept { get; set; }

    public bool? RpaSubmitForSection { get; set; }

    public bool? RpaAcknowledgeForDept { get; set; }

    public bool? RpaAcknowledgeForSection { get; set; }

    public bool? RpaApproveForDept { get; set; }

    public bool? RpaApproveForSection { get; set; }

    public bool? RpaActive { get; set; }

    public string? RpaRmks { get; set; }

    public int? RpaCreatedBy { get; set; }

    public int? RpaEditedBy { get; set; }

    public DateTime? RpaCreationDate { get; set; }

    public DateTime? RpaEditedDate { get; set; }
}
