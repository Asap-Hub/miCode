using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbOperator
{
    public int OprIdpk { get; set; }

    public int? OprEmpIdfk { get; set; }

    public DateTime? OprDate { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? OprCreatedBy { get; set; }

    public bool? OprActive { get; set; }

    public string OprRmks { get; set; } = null!;

    public bool? OprIsShiftLeader { get; set; }

    public string UsaUsername { get; set; } = null!;

    public string? UsaPassword { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public short? GndIdpk { get; set; }

    public string? GndName { get; set; }

    public string? GndshtName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public bool? DptActive { get; set; }

    public string? DptRmks { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public int? Expr1 { get; set; }

    public bool? SxnActive { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public bool? UntActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public string? AreRmks { get; set; }

    public int? TitIdpk { get; set; }

    public string? TitName { get; set; }

    public bool? TitActive { get; set; }

    public string? TitShtName { get; set; }

    public string? TitRmks { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int? LocAreaIdfk { get; set; }

    public bool? LocActive { get; set; }

    public string? LocRmks { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public bool? JobActive { get; set; }

    public string? JobRmks { get; set; }

    public int? JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public string? JobTitle { get; set; }

    public string? RptJobTitle { get; set; }

    public bool? JlvActive { get; set; }

    public bool? OprSeeAllLogs { get; set; }

    public int? OprSubstationIdfk { get; set; }

    public int? StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public bool? StnActive { get; set; }

    public string? StnRmks { get; set; }

    public string? StpName { get; set; }

    public string? StpShtName { get; set; }

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public string? LocShtName { get; set; }

    public int? EmpIdpk { get; set; }

    public DateTime? OprCreationDate { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }
}
