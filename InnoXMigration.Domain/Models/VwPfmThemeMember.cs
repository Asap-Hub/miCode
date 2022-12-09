using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmThemeMember
{
    public int TmbIdpk { get; set; }

    public int? TmbThemeIdfk { get; set; }

    public int? TmbEmpIdfk { get; set; }

    public DateTime? TmbStartDate { get; set; }

    public DateTime? TmbEndDate { get; set; }

    public bool? TmbLeader { get; set; }

    public bool? TmbActive { get; set; }

    public string? TmbRmks { get; set; }

    public int? ThmIdpk { get; set; }

    public int? ThmMissionIdfk { get; set; }

    public string? ThmName { get; set; }

    public bool? ThmActive { get; set; }

    public string? ThmRmks { get; set; }

    public int? MvsIdpk { get; set; }

    public string? MvsName { get; set; }

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string? MvsMission { get; set; }

    public string? MvsMissionSht { get; set; }

    public string? MvsVision { get; set; }

    public string? MvsVisionSht { get; set; }

    public bool? MvsActive { get; set; }

    public byte? ThmOrder { get; set; }

    public string? ThmShtName { get; set; }

    public string? ThmCommentary { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpLegacyName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpName5 { get; set; }

    public string? EmpName6 { get; set; }

    public string? EmpName7 { get; set; }

    public string? EmpName8 { get; set; }

    public string? EmpName9 { get; set; }

    public string? EmpName10 { get; set; }

    public string? EmpName11 { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public int? SxnIdpk { get; set; }

    public string? SxnName { get; set; }

    public string? SxnShtName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public string? EmpIntercom { get; set; }

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }
}
