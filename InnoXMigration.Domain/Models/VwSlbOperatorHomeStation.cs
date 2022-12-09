using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbOperatorHomeStation
{
    public int OhaIdpk { get; set; }

    public string? OhaOprIdfk { get; set; }

    public string? OhaSstIdfk { get; set; }

    public bool? OhaActive { get; set; }

    public int OprIdpk { get; set; }

    public int? OprEmpIdfk { get; set; }

    public DateTime? OprDate { get; set; }

    public string? EmpStaffNo { get; set; }

    public bool? OprIsShiftLeader { get; set; }

    public string UsaUsername { get; set; } = null!;

    public string? UsaPassword { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public string? JobTitle { get; set; }

    public string? LocShtName { get; set; }

    public string? SxnShtName { get; set; }

    public string? DptShtName { get; set; }

    public string? StpShtName { get; set; }

    public string? StpName { get; set; }

    public int StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? OhaRmks { get; set; }

    public int? OhaCreatedBy { get; set; }

    public int? OhaEditedBy { get; set; }

    public DateTime? OhaCreationDate { get; set; }

    public DateTime? OhaEditedDate { get; set; }

    public string? StnPlc { get; set; }

    public bool? StnActive { get; set; }

    public string? StnRmks { get; set; }
}
