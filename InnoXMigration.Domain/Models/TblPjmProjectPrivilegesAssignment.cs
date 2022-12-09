using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmProjectPrivilegesAssignment
{
    public int PpaIdpk { get; set; }

    public int? PpaEmpIdfk { get; set; }

    public int? PpaProjectIdfk { get; set; }

    public bool? PpaCreateLessonsLog { get; set; }

    public bool? PpaUpdateLessonsLog { get; set; }

    public bool? PpaViewLessonsLog { get; set; }

    public bool? PpaCreateRiskRegister { get; set; }

    public bool? PpaUpdateRiskRegister { get; set; }

    public bool? PpaViewRiskRegister { get; set; }

    public bool? PpaCreateIssuesRegister { get; set; }

    public bool? PpaUpdateIssuesRegister { get; set; }

    public bool? PpaViewIssuesRegister { get; set; }

    public bool? PpaCreateQualityRegister { get; set; }

    public bool? PpaUpdateQualityRegister { get; set; }

    public bool? PpaViewQualityRegister { get; set; }

    public bool? PpaActive { get; set; }

    public string? PpaRmks { get; set; }

    public int? PpaCreatedBy { get; set; }

    public int? PpaEditedBy { get; set; }

    public DateTime? PpaCreationDate { get; set; }

    public DateTime? PpaEditedDate { get; set; }
}
