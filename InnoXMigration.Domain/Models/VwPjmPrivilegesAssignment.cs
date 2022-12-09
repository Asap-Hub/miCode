using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmPrivilegesAssignment
{
    public int PpaIdpk { get; set; }

    public int? PpaEmpIdfk { get; set; }

    public int? PpaCreatedBy { get; set; }

    public int? PpaEditedBy { get; set; }

    public DateTime? PpaCreationDate { get; set; }

    public DateTime? PpaEditedDate { get; set; }

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

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? Emplastname { get; set; }

    public string? Empfirstname { get; set; }

    public string Empothernames { get; set; } = null!;

    public string EmpLegacyName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int? PpaProjectIdfk { get; set; }

    public int PjrIdpk { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public bool Pjractive { get; set; }

    public string Pjrrmks { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public string? EmpName12 { get; set; }

    public string PjrPhase { get; set; } = null!;

    public int PnmIdpk { get; set; }

    public string PnmName { get; set; } = null!;

    public string PnmShtName { get; set; } = null!;
}
