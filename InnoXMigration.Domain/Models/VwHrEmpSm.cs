using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrEmpSm
{
    public int EsmIdpk { get; set; }

    public int? EsmEmpIdfk { get; set; }

    public string? EsmMobNo { get; set; }

    public string? EsmMessage { get; set; }

    public bool? EsmSent { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

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

    public string? DptShtName { get; set; }

    public bool? DptActive { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public bool? AreActive { get; set; }

    public string? EmpIntercom { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpPersonalEmail { get; set; }

    public string? EmpOfficialEmail { get; set; }

    public string? EmpTelNo { get; set; }

    public DateTime? DateSent { get; set; }

    public string? DateSentx { get; set; }

    public int? UsaIdpk { get; set; }

    public string? UsaUsername { get; set; }

    public string? SentByName { get; set; }

    public string? SentByName1 { get; set; }

    public string? SentByName2 { get; set; }

    public string? SentByStaffNo { get; set; }

    public string EsmRmks { get; set; } = null!;
}
