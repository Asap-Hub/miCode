using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenAuditLog
{
    public int AlgIdpk { get; set; }

    public string? UsaUsername { get; set; }

    public string? AlgAction { get; set; }

    public int? AlgCreatedBy { get; set; }

    public DateTime? AlgCreationDate { get; set; }

    public string? AlgShortDate { get; set; }

    public int? AfmIdpk { get; set; }

    public string? AfmName { get; set; }

    public string? AfmShtName { get; set; }

    public string? AfmType { get; set; }

    public string? AfmDesc { get; set; }

    public bool? AfmActive { get; set; }

    public bool? AfmVisible { get; set; }

    public DateTime? AfmCreationDate { get; set; }

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmCode { get; set; }

    public string? ApmRmks { get; set; }

    public int? ApmCreatedBy { get; set; }

    public DateTime? ApmCreationDate { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? AlgFormCode { get; set; }

    public string? AlgIp { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public string? DptName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public int? AlgIdpkx { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public short? GndIdpk { get; set; }

    public string? GndName { get; set; }

    public int? GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public int? TitIdpk { get; set; }

    public string? TitName { get; set; }

    public string? AreShtName { get; set; }

    public string? TitShtName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string? LocShtName { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpIntercom { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public int? JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public bool UsaActive { get; set; }

    public bool EmpActive { get; set; }

    public bool EmpIsStaff { get; set; }
}
