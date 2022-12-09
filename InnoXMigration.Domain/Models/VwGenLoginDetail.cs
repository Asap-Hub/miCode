using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenLoginDetail
{
    public int LdtIdpk { get; set; }

    public string? LdtUserIdfk { get; set; }

    public DateTime? LdtLoginDate { get; set; }

    public string? LdtShtLoginDate { get; set; }

    public DateTime? LdtLogoutDate { get; set; }

    public int? LdtLoggedOutBy { get; set; }

    public string? LdtIp { get; set; }

    public string? LdtHostname { get; set; }

    public bool? LdtLoggedIn { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public bool? UsaChangePassword { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int? StpIdpk { get; set; }

    public string? StpName { get; set; }

    public short? GndIdpk { get; set; }

    public string? GndName { get; set; }

    public int? GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public int? TitIdpk { get; set; }

    public string? TitName { get; set; }

    public bool? UsaLoggedIn { get; set; }

    public string? GndshtName { get; set; }

    public string? StpShtName { get; set; }

    public string? GrdShtName { get; set; }

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public string? AreShtName { get; set; }

    public string? TitShtName { get; set; }

    public string? LocShtName { get; set; }

    public string? EmpDirTelNo { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpIntercom { get; set; }

    public string? EmpOfficialEmail { get; set; }

    public string? EmpPersonalEmail { get; set; }

    public DateTime? EmpHireDate { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public int? JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public bool? UsaSeeAllForms { get; set; }

    public bool? UsaSuperUser { get; set; }

    public bool? UsaSeeSalaries { get; set; }

    public bool? UsaEditEmails { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFirstName { get; set; }

    public int? ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public bool? UsaEditIntercom { get; set; }

    public string? JobTitle { get; set; }

    public string? RptJobTitle { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public string? EmpMobNox { get; set; }

    public bool? EmpHideMobNo { get; set; }

    public int? AscIdpk { get; set; }

    public string? AscName { get; set; }

    public string? AscShtName { get; set; }

    public string? EmpName5 { get; set; }

    public string? EmpName6 { get; set; }

    public string? EmpName7 { get; set; }

    public string? EmpName8 { get; set; }

    public string? EmpName9 { get; set; }

    public string? EmpName10 { get; set; }

    public string? EmpName11 { get; set; }

    public bool? UsaShowTipOfDayOnStartup { get; set; }

    public int EmpIdpk { get; set; }

    public int UsaIdpk { get; set; }

    public string LdtAppVersion { get; set; } = null!;

    public DateTime LdtLastAppBuildDate { get; set; }

    public string LdtOsName { get; set; } = null!;

    public string LdtOsPlatform { get; set; } = null!;

    public string LdtOsVersion { get; set; } = null!;

    public long LdtTotalPhysicalMemory { get; set; }

    public long LdtTotalVirtualMemory { get; set; }

    public long LdtAvailablePhysicalMemory { get; set; }

    public long LdtAvailableVirtualMemory { get; set; }

    public bool UsaActive { get; set; }

    public bool EmpActive { get; set; }

    public bool? EmpIsServicePerson { get; set; }

    public bool? EmpIsManagementStaff { get; set; }

    public bool? EmpIsStaff { get; set; }
}
