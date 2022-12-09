using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyTopic
{
    public int StpIdpk { get; set; }

    public string? StpTitle { get; set; }

    public string? StpDescription { get; set; }

    public int? StpSafetyGroupIdfk { get; set; }

    public bool StpApproved { get; set; }

    public bool? StpActive { get; set; }

    public string? StpRmks { get; set; }

    public int? StpCreatedBy { get; set; }

    public int? StpEditedBy { get; set; }

    public DateTime? StpCreationDate { get; set; }

    public DateTime? StpEditedDate { get; set; }

    public bool StpRecommended { get; set; }

    public bool StpRejected { get; set; }

    public int StpRecommendedByEmpIdfk { get; set; }

    public int StpApprovedByEmpIdfk { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName13 { get; set; }

    public string? EmpName15 { get; set; }

    public string? EmpName14 { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName16 { get; set; }

    public bool StpEdit { get; set; }

    public string StpSource { get; set; } = null!;

    public DateTime? StpApprovedOn { get; set; }

    public DateTime? StpRecommendedOn { get; set; }

    public DateTime? StpRejectedOn { get; set; }

    public int RecomByEmpId { get; set; }

    public string? RecomByStaffNo { get; set; }

    public string? RecomByLname { get; set; }

    public string? RecomByFname { get; set; }

    public string? RecomByEmpName { get; set; }

    public string? RecomByEmpName16 { get; set; }

    public int? ApprovedByEmpId { get; set; }

    public string? ApprovedByStaffNo { get; set; }

    public string? ApprovedByLname { get; set; }

    public string? ApprovedByFname { get; set; }

    public string? ApprovedByEmpName { get; set; }

    public string? ApprovedByEmpName16 { get; set; }
}
