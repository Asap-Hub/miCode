using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrRecPrivilegesAssignment
{
    public int RpaIdpk { get; set; }

    public int? RpaEmpIdfk { get; set; }

    public bool? RpaCreateJobOpening { get; set; }

    public bool? RpaReviewJobOpenings { get; set; }

    public bool? RpaReviewApplications { get; set; }

    public bool? RpaScheduleInterviews { get; set; }

    public bool? RpaCaptureInterviewMarks { get; set; }

    public bool? RpaSendAlerts { get; set; }

    public bool? RpaActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpName { get; set; }

    public string EmpMobNo { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpIsCeo { get; set; }

    public bool EmpIsDirector { get; set; }

    public bool EmpIsManager { get; set; }

    public bool EmpIsSupervisor { get; set; }

    public bool? RpaViewAllRequests { get; set; }
}
