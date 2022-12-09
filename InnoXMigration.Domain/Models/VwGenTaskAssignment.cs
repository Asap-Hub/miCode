using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenTaskAssignment
{
    public int AssignedToEmpId { get; set; }

    public string? AssignedToStaffNo { get; set; }

    public string? AssignedToLname { get; set; }

    public string? AssignedToFname { get; set; }

    public string AssignedToOnames { get; set; } = null!;

    public string AssignedToHrmsName { get; set; } = null!;

    public string? AssignedToEmpName { get; set; }

    public string? AssignedToEmpName1 { get; set; }

    public string? AssignedToEmpName2 { get; set; }

    public string? AssignedToEmpName3 { get; set; }

    public int AssignedToDeptId { get; set; }

    public string AssignedToDeptName { get; set; } = null!;

    public string AssignedToDeptShtName { get; set; } = null!;

    public int AssignedToSxnId { get; set; }

    public string AssignedToSxnName { get; set; } = null!;

    public string AssignedToSxnShtName { get; set; } = null!;

    public int AssignedToUnitId { get; set; }

    public string AssignedToUnitName { get; set; } = null!;

    public string AssignedToUnitShtName { get; set; } = null!;

    public int AssignedToLocId { get; set; }

    public string AssignedToLocName { get; set; } = null!;

    public string AssignedToLocShtName { get; set; } = null!;

    public string? AssignedToEmpName14 { get; set; }

    public string? AssignedToEmpName15 { get; set; }

    public int TasIdpk { get; set; }

    public int? TasTaskIdfk { get; set; }

    public int? TasAssignedByEmpIdfk { get; set; }

    public int? TasAssignedToEmpIdfk { get; set; }

    public bool? TasActive { get; set; }

    public int TskIdpk { get; set; }

    public DateTime? TskStartDate { get; set; }

    public DateTime? TskDueDate { get; set; }

    public DateTime? TskCompletionDate { get; set; }

    public decimal TskPercentComplete { get; set; }

    public string? TskAssignedTo { get; set; }

    public int TskStatusIdfk { get; set; }

    public int TskPriorityIdfk { get; set; }

    public string TskSubject { get; set; } = null!;

    public string TskTask { get; set; } = null!;

    public int StsIdpk { get; set; }

    public string StsName { get; set; } = null!;

    public string StsShtName { get; set; } = null!;

    public int TdpIdpk { get; set; }

    public string TdpName { get; set; } = null!;

    public string TdpShtName { get; set; } = null!;

    public int? AssignedByEmpId { get; set; }

    public string? AssignedByStaffNo { get; set; }

    public string? AssignedByLname { get; set; }

    public string? AssignedByFname { get; set; }

    public string? AssignedByOnames { get; set; }

    public string? AssignedByEmpName { get; set; }

    public string? AssignedByEmpName1 { get; set; }

    public string? AssignedByEmpName2 { get; set; }

    public string? AssignedByEmpName3 { get; set; }

    public int? AssignedByDeptId { get; set; }

    public string? AssignedByDeptName { get; set; }

    public int? AssignedBySxnId { get; set; }

    public string? AssignedBySxnName { get; set; }

    public string? AssignedBySxnShtName { get; set; }

    public string? AssignedByDeptShtName { get; set; }

    public string? AssignedByEmpName14 { get; set; }

    public string? AssignedByEmpName15 { get; set; }

    public string AssignedToMobNox { get; set; } = null!;

    public string AssignedToMobNo { get; set; } = null!;
}
